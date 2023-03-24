using ECOLAB.IOT.Entity;

namespace ECOLAB.IOT.WinFormApp
{
    public class CustomMessageBoxDialogResult
    {
        public DialogResult DialogResult { get; set; }=DialogResult.Cancel;

        public ModeEnum ModeEnum { get; set; } = ModeEnum.NormalMode;

        public DGWModeConfig? DGWModeConfig { get; set; }

        public string? TransportProtocol { get; set; }

        public bool IsCRC { get; set; }
    }

    public enum ModeEnum
    {
        NormalMode = 1,
        DGWMode = 2
    }
}
