﻿namespace YpdfDesktop.Models.Localization
{
    public class English : Locale
    {
        public English() : base("en-us", "English")
        {
        }

        protected override void SetLocale()
        {
            Favorites = "Favorites";
            Tools = "Tools";
            Settings = "Settings";
            Tasks = "Tasks";

            Language = "Language";
            Theme = "Theme";
            PythonAlias = "Python path/alias";
            Save = "Save";
            ResetAfterExecution = "Reset after execution";

            Running = "Running";
            Completed = "Completed";
            Faulted = "Faulted";

            From = "From";
            To = "To";
            Execute = "Execute";
            Reset = "Reset";
            File = "File";
            Output = "Output";
            QualityFactor = "Quality factor";
            SizeFactor = "Size factor";
            Extension = "Extension";
            CheckCompressionValidity = "Check compression validity";
            UseTika = "Use tika";
            Password = "Password";
            OwnerPassword = "Owner password";
            UserPassword = "User password";
            OwnerPasswordHint = "Password for editing the PDF document";
            UserPasswordHint = "Password for viewing the PDF document";
            EncryptionAlgorithm = "Encryption algorithm";
            ShowPassword = "Show password";
            TextAlignment = "Text alignment";
            FontPath = "Font path";
            FontSize = "Font size";
            FontFamily = "Font family";
            FontColor = "Font color";
            FontOpacity = "Font opacity";
            FontEncoding = "Font encoding";
            PageSize = "Page size";
            PageWidth = "Page width";
            PageHeight = "Page height";
            Margin = "Margin";

            Split = "split";
            Merge = "merge";
            Compress = "compress";
            HandlePages = "handle pages";
            CropPages = "crop pages";
            DividePages = "divide pages";
            AddPageNumbers = "add page nums";
            AddWatermark = "add watermark";
            RemoveWatermark = "rm watermark";
            ImageToPdf = "image2pdf";
            TextToPdf = "text2pdf";
            ExtractImages = "extract images";
            ExtractText = "extract text";
            SetPassword = "set password";
            RemovePassword = "rm password";

            Yes = "Yes";
            No = "No";
            Custom = "Custom";

            FileEmptyMessage = "File is empty";
            FileExistsMessage = "File already exists";
            FileNotPdfMessage = "File is not PDF document";
            FileNotTxtMessage = "File is not TXT document";
            ReplaceItMessage = "Replace it";
            UnfinishedTasksMessage = "You have unfinished tasks";
            ExitWithoutWaitingForCompletionMessage = "Exit without waiting for completion";
            SpecifyOutputFilePathMessage = "Specify the output file path";
            SpecifyCorrectQualityFactorMessage = "Specify the quality factor";
            SpecifyCorrectSizeFactorMessage = "Specify the size factor";
            SpecifyAtLeastOnePasswordMessage = "Specify at least one password";
            SpecifyPasswordMessage = "Specify the password";
        }
    }
}
