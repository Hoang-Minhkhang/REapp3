 if (string.IsNullOrEmpty(currentPdfPath))
        return;

    Process.Start("rundll32.exe",
        $"shell32.dll,OpenAs_RunDLL \"{currentPdfPath}\"");