using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Vannatech.CoreAudio.Constants;
using Vannatech.CoreAudio.Enumerations;
using Vannatech.CoreAudio.Externals;
using Vannatech.CoreAudio.Interfaces;

namespace Spinpreach.SwordsDanceViewer
{
    public class Audio : IAudioSessionEvents
    {

        #region EventHandler

        #region MuteChanged

        public delegate void MuteChangedEventHandler(bool isMuted);

        public event MuteChangedEventHandler MuteChangedEvent;

        protected virtual void OnMuteChanged(bool isMuted)
        {
            if (this.MuteChangedEvent != null)
            {
                this.MuteChangedEvent(isMuted);
            }
        }

        #endregion

        #endregion

        #region Member

        private ISimpleAudioVolume AudioVolume;
        private IAudioSessionControl AudioControl;

        #endregion

        #region Constructor

        public Audio()
        {
            this.AudioVolume = null;

            var deviceEnumeratorType = Type.GetTypeFromCLSID(new Guid(ComCLSIDs.MMDeviceEnumeratorCLSID));
            var devenum = (IMMDeviceEnumerator)Activator.CreateInstance(deviceEnumeratorType);

            IMMDevice device = null;
            if (devenum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia, out device) == 0)
            {
                var iid = new Guid(ComIIDs.IAudioSessionManager2IID);
                object objAudioSessionManager = null;
                if (device.Activate(iid, (uint)CLSCTX.CLSCTX_INPROC_SERVER, IntPtr.Zero, out objAudioSessionManager) == 0)
                {
                    var AudioSessionManager = objAudioSessionManager as IAudioSessionManager2;

                    ISimpleAudioVolume AudioVolume;
                    if (AudioSessionManager.GetSimpleAudioVolume(Guid.Empty, 0, out AudioVolume) == 0)
                    {
                        this.AudioVolume = AudioVolume;
                    }

                    IAudioSessionControl AudioControl;
                    if (AudioSessionManager.GetAudioSessionControl(Guid.Empty, 0, out AudioControl) == 0)
                    {
                        this.AudioControl = AudioControl;
                        this.AudioControl.RegisterAudioSessionNotification(this);
                    }

                }
            }
        }

        #endregion

        #region method

        #region IsMute

        public bool IsMute()
        {
            bool isMute = true;
            AudioVolume.GetMute(out isMute);
            return isMute;
        }

        #endregion

        #region ToggleMute

        public void ToggleMute()
        {
            bool isMute = true;
            AudioVolume.GetMute(out isMute);
            AudioVolume.SetMute(!isMute, Guid.Empty);
        }

        #endregion

        #endregion

        #region IAudioSession interface

        public int OnChannelVolumeChanged([In, MarshalAs(UnmanagedType.U4)] uint channelCount, [In, MarshalAs(UnmanagedType.SysInt)] IntPtr newVolumes, [In, MarshalAs(UnmanagedType.U4)] uint channelIndex, [In] ref Guid eventContext)
        {
            return 0;
        }

        public int OnDisplayNameChanged([In, MarshalAs(UnmanagedType.LPWStr)] string displayName, [In] ref Guid eventContext)
        {
            return 0;
        }

        public int OnGroupingParamChanged([In] ref Guid groupingId, [In] ref Guid eventContext)
        {
            return 0;
        }

        public int OnIconPathChanged([In, MarshalAs(UnmanagedType.LPWStr)] string iconPath, [In] ref Guid eventContext)
        {
            return 0;
        }

        public int OnSessionDisconnected([In] AudioSessionDisconnectReason disconnectReason)
        {
            return 0;
        }

        public int OnSimpleVolumeChanged([In, MarshalAs(UnmanagedType.R4)] float volume, [In, MarshalAs(UnmanagedType.Bool)] bool isMuted, [In] ref Guid eventContext)
        {
            this.OnMuteChanged(isMuted);
            return 0;
        }

        public int OnStateChanged([In] AudioSessionState state)
        {
            return 0;
        }

        #endregion

    }
}
