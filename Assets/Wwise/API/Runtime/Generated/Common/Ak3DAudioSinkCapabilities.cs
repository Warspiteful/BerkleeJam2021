#if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.
//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Ak3DAudioSinkCapabilities : global::System.IDisposable {
  private global::System.IntPtr swigCPtr;
  protected bool swigCMemOwn;

  internal Ak3DAudioSinkCapabilities(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  internal static global::System.IntPtr getCPtr(Ak3DAudioSinkCapabilities obj) {
    return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;
  }

  internal virtual void setCPtr(global::System.IntPtr cPtr) {
    Dispose();
    swigCPtr = cPtr;
  }

  ~Ak3DAudioSinkCapabilities() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AkSoundEnginePINVOKE.CSharp_delete_Ak3DAudioSinkCapabilities(swigCPtr);
        }
        swigCPtr = global::System.IntPtr.Zero;
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public AkChannelConfig channelConfig { set { AkSoundEnginePINVOKE.CSharp_Ak3DAudioSinkCapabilities_channelConfig_set(swigCPtr, AkChannelConfig.getCPtr(value)); } 
    get {
      global::System.IntPtr cPtr = AkSoundEnginePINVOKE.CSharp_Ak3DAudioSinkCapabilities_channelConfig_get(swigCPtr);
      AkChannelConfig ret = (cPtr == global::System.IntPtr.Zero) ? null : new AkChannelConfig(cPtr, false);
      return ret;
    } 
  }

  public uint uMaxSystemAudioObjects { set { AkSoundEnginePINVOKE.CSharp_Ak3DAudioSinkCapabilities_uMaxSystemAudioObjects_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_Ak3DAudioSinkCapabilities_uMaxSystemAudioObjects_get(swigCPtr); } 
  }

  public uint uAvailableSystemAudioObjects { set { AkSoundEnginePINVOKE.CSharp_Ak3DAudioSinkCapabilities_uAvailableSystemAudioObjects_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_Ak3DAudioSinkCapabilities_uAvailableSystemAudioObjects_get(swigCPtr); } 
  }

  public bool bPassthrough { set { AkSoundEnginePINVOKE.CSharp_Ak3DAudioSinkCapabilities_bPassthrough_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_Ak3DAudioSinkCapabilities_bPassthrough_get(swigCPtr); } 
  }

  public bool bMultiChannelObjects { set { AkSoundEnginePINVOKE.CSharp_Ak3DAudioSinkCapabilities_bMultiChannelObjects_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_Ak3DAudioSinkCapabilities_bMultiChannelObjects_get(swigCPtr); } 
  }

  public Ak3DAudioSinkCapabilities() : this(AkSoundEnginePINVOKE.CSharp_new_Ak3DAudioSinkCapabilities(), true) {
  }

}
#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.