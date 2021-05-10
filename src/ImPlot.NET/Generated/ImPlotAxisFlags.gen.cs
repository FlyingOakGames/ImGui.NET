namespace ImPlotNET
{
    [System.Flags]
    public enum ImPlotAxisFlags
    {
        None = 0,
        NoLabel = 1,
        NoGridLines = 2,
        NoTickMarks = 4,
        NoTickLabels = 8,
        LogScale = 16,
        Time = 32,
        Invert = 64,
        AutoFit = 128,
        LockMin = 256,
        LockMax = 512,
        Lock = 768,
        NoDecorations = 15,
    }
}
