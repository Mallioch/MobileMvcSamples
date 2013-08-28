using System;
using System.Text;
using System.Web.Mvc;

namespace MobileMvcSamples.Helpers
{
    public static class DeviceCoverageHelper
    {
        private const string EmptyCell = "<td class=\"empty\"></td>";
        public const string DefaultSetName = "defaultset";

        public static MvcHtmlString DeviceCoverage(this HtmlHelper helper, string name = "defaultset")
        {
            if (helper.ViewData[name] == null)
                return MvcHtmlString.Create("<p>The specified set has not been setup.</p>");

            var coverage = helper.ViewData[name] as DeviceCoverage;

            var sb = new StringBuilder();
            sb.Append("<table class=\"coverage\">");
            iOS(sb, coverage);
            Android(sb, coverage);
            AndroidChrome(sb, coverage);
            BlackBerry(sb, coverage);
            WindowsPhone(sb, coverage);
            FirefoxMobile(sb, coverage);
            Opera(sb, coverage);
            DesktopChrome(sb, coverage);
            DesktopFirefox(sb, coverage);
            DesktopInternetExplorer(sb, coverage);
            TabletInternetExplorer(sb, coverage);
            KindleFire(sb, coverage);
            NexusTablets(sb, coverage);
            sb.Append("</table>");

            return MvcHtmlString.Create(sb.ToString());
        }

        private static string CreateCell(DeviceCoverageAmount value, string label)
        {
            string css = "unknown";
            if (value == DeviceCoverageAmount.No)
                css = "no";
            else if (value == DeviceCoverageAmount.Yes)
                css = "yes";
            else if (value == DeviceCoverageAmount.Partial)
                css = "partial";

            return "<td class=\"" + css + "\">" + label + "</td>";
        }

        private static void Android(StringBuilder sb, DeviceCoverage coverage)
        {
            sb.Append("<tr>");
            sb.Append("<td class=\"browser\">Android Browser</td>");
            sb.Append(CreateCell(coverage.Android_2_1, "2.1"));
            sb.Append(CreateCell(coverage.Android_2_2, "2.2"));
            sb.Append(CreateCell(coverage.Android_2_3, "2.3"));
            sb.Append(CreateCell(coverage.Android_4_1, "4.1"));
            sb.Append("</tr>");
        }

        private static void AndroidChrome(StringBuilder sb, DeviceCoverage coverage)
        {
            sb.Append("<tr>");
            sb.Append("<td class=\"browser\">Android Chrome</td>");
            sb.Append(EmptyCell);
            sb.Append(EmptyCell);
            sb.Append(EmptyCell);
            sb.Append(CreateCell(coverage.Android_4_1_Chrome, "4.1"));
            sb.Append("</tr>");
        }

        private static void iOS(StringBuilder sb, DeviceCoverage coverage)
        {
            sb.Append("<tr>");
            sb.Append("<td class=\"browser\">iOS</td>");
            sb.Append(CreateCell(coverage.iOS_4, "4"));
            sb.Append(CreateCell(coverage.iOS_5, "5"));
            sb.Append(CreateCell(coverage.iOS_6, "6"));
            sb.Append(CreateCell(coverage.iOS_7, "7"));
            sb.Append("</tr>");
        }

        private static void BlackBerry(StringBuilder sb, DeviceCoverage coverage)
        {
            sb.Append("<tr>");
            sb.Append("<td class=\"browser\">BlackBerry</td>");
            sb.Append(EmptyCell);
            sb.Append(EmptyCell);
            sb.Append(EmptyCell);
            sb.Append(CreateCell(coverage.BlackBerry10, "10"));
            sb.Append("</tr>");
        }

        private static void WindowsPhone(StringBuilder sb, Helpers.DeviceCoverage coverage)
        {
            sb.Append("<tr>");
            sb.Append("<td class=\"browser\">Windows Phone</td>");
            sb.Append(EmptyCell);
            sb.Append(EmptyCell);
            sb.Append(CreateCell(coverage.WindowsPhone7_5, "7.5"));
            sb.Append(CreateCell(coverage.WindowsPhone8, "8"));
            sb.Append("</tr>");
        }

        private static void FirefoxMobile(StringBuilder sb, Helpers.DeviceCoverage coverage)
        {
            sb.Append("<tr>");
            sb.Append("<td class=\"browser\">Firefox on Android</td>");
            sb.Append(EmptyCell);
            sb.Append(EmptyCell);
            sb.Append(EmptyCell);
            sb.Append(CreateCell(coverage.Firefox_Android, "?"));
            sb.Append("</tr>");
        }

        private static void Opera(StringBuilder sb, Helpers.DeviceCoverage coverage)
        {
            sb.Append("<tr>");
            sb.Append("<td class=\"browser\">Opera Mobile</td>");
            sb.Append(EmptyCell);
            sb.Append(EmptyCell);
            sb.Append(CreateCell(coverage.Opera_Classic_Android, "12"));
            sb.Append(CreateCell(coverage.Opera_Webkit_Android, "15"));
            sb.Append("</tr>");
        }

        private static void DesktopChrome(StringBuilder sb, Helpers.DeviceCoverage coverage)
        {
            sb.Append("<tr>");
            sb.Append("<td class=\"browser\">Chrome Desktop</td>");
            sb.Append(EmptyCell);
            sb.Append(EmptyCell);
            sb.Append(EmptyCell);
            sb.Append(CreateCell(coverage.Desktop_Chrome, "28"));
            sb.Append("</tr>");
        }

        private static void TabletInternetExplorer(StringBuilder sb, Helpers.DeviceCoverage coverage)
        {
            sb.Append("<tr>");
            sb.Append("<td class=\"browser\">IE Tablet</td>");
            sb.Append(EmptyCell);
            sb.Append(EmptyCell);
            sb.Append(EmptyCell);
            sb.Append(CreateCell(coverage.Tablet_InternetExplorer10, "10"));
            sb.Append("</tr>");
        }

        private static void DesktopInternetExplorer(StringBuilder sb, Helpers.DeviceCoverage coverage)
        {
            sb.Append("<tr>");
            sb.Append("<td class=\"browser\">IE Desktop</td>");
            sb.Append(EmptyCell);
            sb.Append(EmptyCell);
            sb.Append(EmptyCell);
            sb.Append(CreateCell(coverage.Desktop_InternetExplorer10, "10"));
            sb.Append("</tr>");
        }

        private static void DesktopFirefox(StringBuilder sb, Helpers.DeviceCoverage coverage)
        {
            sb.Append("<tr>");
            sb.Append("<td class=\"browser\">Firefox Desktop</td>");
            sb.Append(EmptyCell);
            sb.Append(EmptyCell);
            sb.Append(EmptyCell);
            sb.Append(CreateCell(coverage.Desktop_Firefox, "22"));
            sb.Append("</tr>");
        }

        private static void NexusTablets(StringBuilder sb, Helpers.DeviceCoverage coverage)
        {
            sb.Append("<tr>");
            sb.Append("<td class=\"browser\">Android Nexus Tablet</td>");
            sb.Append(EmptyCell);
            sb.Append(EmptyCell);
            sb.Append(EmptyCell);
            sb.Append(CreateCell(coverage.GalaxyNexus7, "4.2.2"));
            sb.Append("</tr>");
        }

        private static void KindleFire(StringBuilder sb, Helpers.DeviceCoverage coverage)
        {
            sb.Append("<tr>");
            sb.Append("<td class=\"browser\">Kindle Fire</td>");
            sb.Append(EmptyCell);
            sb.Append(EmptyCell);
            sb.Append(CreateCell(coverage.KindleFire_FirstGen, "1"));
            sb.Append(CreateCell(coverage.KindleFire_HD, "HD"));
            sb.Append("</tr>");
        }
    }

    public enum DeviceCoverageAmount
    {
        No = 0,
        Yes = 1,
        Unknown = 2,
        Partial = 3
    }

    public class DeviceCoverage
    {
        public DeviceCoverageAmount Android_2_1 { get; set; }
        public DeviceCoverageAmount Android_2_2 { get; set; }
        public DeviceCoverageAmount Android_2_3 { get; set; }
        public DeviceCoverageAmount Android_4_1 { get; set; }
        public DeviceCoverageAmount Android_4_1_Chrome { get; set; }

        public DeviceCoverageAmount iOS_4 { get; set; }
        public DeviceCoverageAmount iOS_5 { get; set; }
        public DeviceCoverageAmount iOS_6 { get; set; }
        public DeviceCoverageAmount iOS_7 { get; set; }

        public DeviceCoverageAmount BlackBerry10 { get; set; }

        public DeviceCoverageAmount WindowsPhone7_5 { get; set; }
        public DeviceCoverageAmount WindowsPhone8 { get; set; }

        public DeviceCoverageAmount Desktop_Chrome { get; set; }
        public DeviceCoverageAmount Desktop_Firefox { get; set; }
        public DeviceCoverageAmount Desktop_InternetExplorer10 { get; set; }
        public DeviceCoverageAmount Tablet_InternetExplorer10 { get; set; }

        public DeviceCoverageAmount FirefoxOS { get; set; }
        public DeviceCoverageAmount Firefox_Android { get; set; }

        public DeviceCoverageAmount Opera_Classic_Android { get; set; }
        public DeviceCoverageAmount Opera_Webkit_Android { get; set; }

        public DeviceCoverageAmount KindleFire_FirstGen { get; set; }
        public DeviceCoverageAmount KindleFire_HD { get; set; }

        public DeviceCoverageAmount GalaxyNexus7 { get; set; }
    }

    /*
            ViewData[DeviceCoverageHelper.DefaultSetName] = new DeviceCoverage
            {
                Android_2_1 = DeviceCoverageAmount.Unknown,
                Android_2_2 = DeviceCoverageAmount.Unknown,
                Android_2_3 = DeviceCoverageAmount.Unknown,
                Android_4_1 = DeviceCoverageAmount.Unknown,
                Android_4_1_Chrome = DeviceCoverageAmount.Unknown,
                iOS_4 = DeviceCoverageAmount.Unknown,
                iOS_5 = DeviceCoverageAmount.Unknown,
                iOS_6 = DeviceCoverageAmount.Unknown,
                iOS_7 = DeviceCoverageAmount.Unknown,
                BlackBerry10 = DeviceCoverageAmount.Unknown,
                Firefox_Android = DeviceCoverageAmount.Unknown,
                FirefoxOS = DeviceCoverageAmount.Unknown,
                Opera_Classic_Android = DeviceCoverageAmount.Unknown,
                Opera_Webkit_Android = DeviceCoverageAmount.Unknown,
                WindowsPhone7_5 = DeviceCoverageAmount.Unknown,
                WindowsPhone8 = DeviceCoverageAmount.Unknown,
                Desktop_Chrome = DeviceCoverageAmount.Unknown,
                Desktop_Firefox = DeviceCoverageAmount.Unknown,
                Desktop_InternetExplorer10 = DeviceCoverageAmount.Unknown,
                Tablet_InternetExplorer10 = DeviceCoverageAmount.Unknown,
                KindleFire_FirstGen = DeviceCoverageAmount.Unknown,
                KindleFire_HD = DeviceCoverageAmount.Unknown,
                GalaxyNexus7 = DeviceCoverageAmount.Unknown
            };
     */

}