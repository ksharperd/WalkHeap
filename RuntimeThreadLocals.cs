using System.Runtime.InteropServices;

namespace WalkHeap;

[StructLayout(LayoutKind.Explicit)]
internal struct RuntimeThreadLocals
{

    [FieldOffset(0)]
#if NET10_0_OR_GREATER
    public ee_alloc_context alloc_context;
#else
    public gc_alloc_context alloc_context;
#endif

};
