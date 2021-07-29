/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace Firebase.Firestore {

internal class DocumentSnapshotProxy : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DocumentSnapshotProxy(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DocumentSnapshotProxy obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~DocumentSnapshotProxy() {
    Dispose();
  }

  public virtual void Dispose() {

    lock (FirebaseApp.disposeLock) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FirestoreCppPINVOKE.delete_DocumentSnapshotProxy(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(
            null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual string id() {
    string ret = FirestoreCppPINVOKE.DocumentSnapshotProxy_id(swigCPtr);
    if (FirestoreCppPINVOKE.SWIGPendingException.Pending) throw FirestoreCppPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual DocumentReferenceProxy reference() {
    DocumentReferenceProxy ret = new DocumentReferenceProxy(FirestoreCppPINVOKE.DocumentSnapshotProxy_reference(swigCPtr), true);
    if (FirestoreCppPINVOKE.SWIGPendingException.Pending) throw FirestoreCppPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SnapshotMetadataProxy metadata() {
    SnapshotMetadataProxy ret = new SnapshotMetadataProxy(FirestoreCppPINVOKE.DocumentSnapshotProxy_metadata(swigCPtr), true);
    if (FirestoreCppPINVOKE.SWIGPendingException.Pending) throw FirestoreCppPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool exists() {
    bool ret = FirestoreCppPINVOKE.DocumentSnapshotProxy_exists(swigCPtr);
    if (FirestoreCppPINVOKE.SWIGPendingException.Pending) throw FirestoreCppPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual FieldValueProxy Get(string field, DocumentSnapshotProxy.ServerTimestampBehavior stb) {
    FieldValueProxy ret = new FieldValueProxy(FirestoreCppPINVOKE.DocumentSnapshotProxy_Get__SWIG_0(swigCPtr, field, (int)stb), true);
    if (FirestoreCppPINVOKE.SWIGPendingException.Pending) throw FirestoreCppPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual FieldValueProxy Get(string field) {
    FieldValueProxy ret = new FieldValueProxy(FirestoreCppPINVOKE.DocumentSnapshotProxy_Get__SWIG_1(swigCPtr, field), true);
    if (FirestoreCppPINVOKE.SWIGPendingException.Pending) throw FirestoreCppPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual FieldValueProxy Get(FieldPathProxy field, DocumentSnapshotProxy.ServerTimestampBehavior stb) {
    FieldValueProxy ret = new FieldValueProxy(FirestoreCppPINVOKE.DocumentSnapshotProxy_Get__SWIG_4(swigCPtr, FieldPathProxy.getCPtr(field), (int)stb), true);
    if (FirestoreCppPINVOKE.SWIGPendingException.Pending) throw FirestoreCppPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual FieldValueProxy Get(FieldPathProxy field) {
    FieldValueProxy ret = new FieldValueProxy(FirestoreCppPINVOKE.DocumentSnapshotProxy_Get__SWIG_5(swigCPtr, FieldPathProxy.getCPtr(field)), true);
    if (FirestoreCppPINVOKE.SWIGPendingException.Pending) throw FirestoreCppPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum ServerTimestampBehavior {
    None = 0,
    Estimate,
    Previous,
    Default = 0
  }

}

}