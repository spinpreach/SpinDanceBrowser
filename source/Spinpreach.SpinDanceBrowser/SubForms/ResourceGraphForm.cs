using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Windows.Forms.DataVisualization.Charting;

using Spinpreach.SwordsDanceBase;

namespace Spinpreach.SpinDanceBrowser.SubForms
{
    public partial class ResourceGraphForm : Form
    {

        private SwordsDanceDatabase database;
        private DateTime Month { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        private Action transactions_castlekeep;

        public ResourceGraphForm(SwordsDanceDatabase database)
        {
            InitializeComponent();
            this.database = database;
            this.transactions_castlekeep = () => { try { this.Invoke(new EventHandler(this.MonthLabel_TextChanged)); } catch (Exception) { } };
            Common.ShapeMemory.Load(this);
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = string.Format("回転剣舞 ver {0}.{1}.{2}", version.Major, version.Minor, version.Build);
            this.chart0();
        }

        private void ResourceGraphForm_Shown(object sender, EventArgs e)
        {
            this.MonthLabel.Text = this.Month.ToString("yyyy / MM");
            this.database.tableNotify.transactions_castlekeep += this.transactions_castlekeep;
        }

        private void ResourceGraphForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.database.tableNotify.transactions_castlekeep -= this.transactions_castlekeep;
            Common.ShapeMemory.Save(this);
        }

        private void PreviousMonthButton_Click(object sender, EventArgs e)
        {
            this.Month = this.Month.AddMonths(-1);
            this.MonthLabel.Text = this.Month.ToString("yyyy / MM");
        }

        private void NextMonthButton_Click(object sender, EventArgs e)
        {
            this.Month = this.Month.AddMonths(1);
            this.MonthLabel.Text = this.Month.ToString("yyyy / MM");
        }

        private void MonthLabel_DoubleClick(object sender, EventArgs e)
        {
            this.Month = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            this.MonthLabel.Text = this.Month.ToString("yyyy / MM");
        }

        private void MonthLabel_TextChanged(object sender, EventArgs e)
        {
            if (string.Empty.Equals(this.database.table.transaction.castlekeep.name)) return;
            var list = new List<SQLiteHelper.Resource.Row>();
            using (var table = new SQLiteHelper.Resource(this.database.table.transaction.castlekeep.name))
            {
                list = table.Full();
            }
            this.chart1(list);
        }

        private void chart0()
        {

            #region ChartAreas

            var chartArea = new ChartArea();

            Axis ax = chartArea.AxisX;
            ax.Minimum = 1;
            ax.Maximum = this.Month.AddMonths(1).AddDays(-1).Day;
            ax.Interval = 1;
            ax.MajorGrid.LineColor = Color.LightGray;

            Axis ay = chartArea.AxisY;
            //ay.MajorGrid.Enabled = false;
            //ay.MajorTickMark.Interval = 10000;
            ay.Interval = 10000;
            //ay.LabelStyle.Enabled = false;
            ay.Minimum = 0;

            this.chart.ChartAreas.Add(chartArea);

            #endregion

            #region Legends

            // 凡例

            var legend = new Legend();

            legend.Font = new Font("Yu Gothic UI", 9F); // 凡例のフォントサイズ変更

            this.chart.Legends.Add(legend);

            #endregion

            #region Series

            // charcoal : 木炭
            var series1 = new Series() { ChartType = SeriesChartType.Spline, MarkerStyle = MarkerStyle.Circle, YAxisType = AxisType.Primary, MarkerSize = 5 };
            series1.Name = "charcoal";
            series1.LegendText = "木炭";
            this.chart.Series.Add(series1);

            // steel : 玉鋼
            var series2 = new Series() { ChartType = SeriesChartType.Spline, MarkerStyle = MarkerStyle.Circle, YAxisType = AxisType.Primary, MarkerSize = 5 };
            series2.Name = "steel";
            series2.LegendText = "玉鋼";
            this.chart.Series.Add(series2);

            // coolant : 冷却材
            var series3 = new Series() { ChartType = SeriesChartType.Spline, MarkerStyle = MarkerStyle.Circle, YAxisType = AxisType.Primary, MarkerSize = 5 };
            series3.Name = "coolant";
            series3.LegendText = "冷却材";
            this.chart.Series.Add(series3);

            // file : 砥石
            var series4 = new Series() { ChartType = SeriesChartType.Spline, MarkerStyle = MarkerStyle.Circle, YAxisType = AxisType.Primary, MarkerSize = 5 };
            series4.Name = "file";
            series4.LegendText = "砥石";
            this.chart.Series.Add(series4);

            #endregion

        }

        private void chart1(List<SQLiteHelper.Resource.Row> list)
        {

            this.chart.Series["charcoal"].Points.Clear();
            this.chart.Series["steel"].Points.Clear();
            this.chart.Series["coolant"].Points.Clear();
            this.chart.Series["file"].Points.Clear();

            list.Where(x => x.date.Year.Equals(this.Month.Year))
                .Where(x => x.date.Month.Equals(this.Month.Month))
                .ToList().ForEach(x =>
                {

                    DataPoint dp = new DataPoint();

                    dp = new DataPoint();
                    dp.SetValueXY(x.date.Day, x.charcoal);
                    this.chart.Series["charcoal"].Points.Add(dp);

                    dp = new DataPoint();
                    dp.SetValueXY(x.date.Day, x.steel);
                    this.chart.Series["steel"].Points.Add(dp);

                    dp = new DataPoint();
                    dp.SetValueXY(x.date.Day, x.coolant);
                    this.chart.Series["coolant"].Points.Add(dp);

                    dp = new DataPoint();
                    dp.SetValueXY(x.date.Day, x.file);
                    this.chart.Series["file"].Points.Add(dp);

                });

        }

    }
}