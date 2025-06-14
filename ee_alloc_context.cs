using System.Runtime.InteropServices;

namespace WalkHeap;

[StructLayout(LayoutKind.Sequential)]
internal unsafe struct ee_alloc_context
{
    public nint m_CombinedLimit;
    public gc_alloc_context m_GCAllocContext;
    // ...
}
