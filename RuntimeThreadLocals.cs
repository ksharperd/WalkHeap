using System.Runtime.InteropServices;

namespace WalkHeap;

[StructLayout(LayoutKind.Explicit)]
internal struct RuntimeThreadLocals
{

    [FieldOffset(0)]
    public gc_alloc_context alloc_context;

};
