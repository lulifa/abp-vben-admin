﻿namespace RuiChen.Platform.Theme.VueVbenAdmin;

public class ThemeSettingDto
{
    public string DarkMode { get; set; } = "light";
    public ProjectConfigDto ProjectConfig { get; set; } = new ProjectConfigDto();
    public BeforeMiniStateDto BeforeMiniInfo { get; set; } = new BeforeMiniStateDto();
}
