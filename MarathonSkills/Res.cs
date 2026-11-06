using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace MarathonSkills
{
    /// <summary>
    /// Загрузка файлов из папок «Ресурсы» методички (CharityData, marathon-photos, map-icons,
    /// how-long-is-a-marathon-images, marathon-info.txt). Папки нужно скопировать в корень
    /// проекта (рядом с MarathonSkills.csproj) — как сказано в ПР 7. Если файла нет,
    /// вместо картинки рисуется заглушка, чтобы приложение не падало.
    /// </summary>
    public static class Res
    {
        public static string Find(string relPath)
        {
            string[] roots =
            {
                Application.StartupPath,
                Path.Combine(Application.StartupPath, @"..\.."),
                Path.Combine(Application.StartupPath, @"..\..\.."),
                Environment.CurrentDirectory
            };
            foreach (string root in roots)
            {
                string p = Path.GetFullPath(Path.Combine(root, relPath));
                if (File.Exists(p)) return p;
            }
            return null;
        }

        public static Image LoadImage(string relPath, string placeholderText)
        {
            string p = relPath == null ? null : Find(relPath);
            if (p != null)
            {
                try
                {
                    // копия в памяти, чтобы файл не оставался заблокированным
                    using (var img = Image.FromFile(p)) return new Bitmap(img);
                }
                catch { }
            }
            return placeholderText == null ? null : Placeholder(placeholderText);
        }

        public static string ReadText(string relPath)
        {
            string p = Find(relPath);
            return p == null ? null : File.ReadAllText(p);
        }

        public static Image Placeholder(string text)
        {
            var bmp = new Bitmap(240, 120);
            using (var g = Graphics.FromImage(bmp))
            using (var f = new Font("Arial", 11))
            {
                g.Clear(Color.WhiteSmoke);
                g.DrawRectangle(Pens.Silver, 0, 0, 239, 119);
                var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                g.DrawString(text, f, Brushes.DimGray, new RectangleF(0, 0, 240, 120), sf);
            }
            return bmp;
        }

        // ---- заглушки для интерактивной карты (ПР 24) ----
        public static Image DrawMap(int w, int h)
        {
            var bmp = new Bitmap(w, h);
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.FromArgb(242, 242, 236));
                using (var road = new Pen(Color.White, 6))
                    for (int i = 0; i < 9; i++)
                    {
                        g.DrawLine(road, 0, i * h / 8 + 10, w, i * h / 8 - 25);
                        g.DrawLine(road, i * w / 8, 0, i * w / 8 + 30, h);
                    }
                using (var park = new SolidBrush(Color.FromArgb(120, 190, 120)))
                {
                    g.FillPolygon(park, new[] { new Point(w * 55 / 100, h * 35 / 100), new Point(w * 75 / 100, h * 20 / 100), new Point(w * 80 / 100, h * 45 / 100), new Point(w * 60 / 100, h * 60 / 100) });
                    g.FillPolygon(park, new[] { new Point(w * 15 / 100, h * 80 / 100), new Point(w * 30 / 100, h * 60 / 100), new Point(w * 38 / 100, h * 85 / 100) });
                }
                using (var route = new Pen(Color.DeepSkyBlue, 3) { DashStyle = DashStyle.Dot })
                    g.DrawPolygon(route, new[]
                    {
                        new Point(w * 60 / 100, h * 8 / 100), new Point(w * 92 / 100, h * 10 / 100), new Point(w * 90 / 100, h * 80 / 100),
                        new Point(w * 40 / 100, h * 95 / 100), new Point(w * 18 / 100, h * 80 / 100), new Point(w * 18 / 100, h * 45 / 100),
                        new Point(w * 10 / 100, h * 10 / 100), new Point(w * 43 / 100, h * 18 / 100), new Point(w * 53 / 100, h * 60 / 100)
                    });
            }
            return bmp;
        }

        public static Image DrawMarker(string text, bool start)
        {
            int w = start ? 44 : 30, h = 30;
            var bmp = new Bitmap(w, h);
            using (var g = Graphics.FromImage(bmp))
            using (var f = new Font("Arial", start ? 7 : 11, FontStyle.Bold))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);
                using (var b = new SolidBrush(start ? Color.ForestGreen : Color.Orange))
                    if (start) g.FillRectangle(b, 0, 4, w - 1, h - 9); else g.FillEllipse(b, 1, 1, w - 3, h - 3);
                var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                g.DrawString(text, f, Brushes.White, new RectangleF(0, 0, w, h), sf);
            }
            return bmp;
        }

        public static Image DrawIcon(string fileName)
        {
            Color c = Color.Gray; string t = "?";
            if (fileName.Contains("drinks")) { c = Color.MediumPurple; t = "Н"; }
            else if (fileName.Contains("energy")) { c = Color.LimeGreen; t = "Э"; }
            else if (fileName.Contains("toilets")) { c = Color.DimGray; t = "WC"; }
            else if (fileName.Contains("information")) { c = Color.RoyalBlue; t = "i"; }
            else if (fileName.Contains("medical")) { c = Color.Red; t = "+"; }
            var bmp = new Bitmap(36, 36);
            using (var g = Graphics.FromImage(bmp))
            using (var f = new Font("Arial", 11, FontStyle.Bold))
            using (var b = new SolidBrush(c))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.FillEllipse(b, 1, 1, 33, 33);
                var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                g.DrawString(t, f, Brushes.White, new RectangleF(0, 0, 36, 36), sf);
            }
            return bmp;
        }

        /// <summary>Текст о марафоне (на случай, если файл marathon-info.txt не скопирован).</summary>
        public const string MarathonInfo =
@"Marathon Skills - фестиваль бега, проводимый каждый год в разных частях мира. Может быть три зачета: Полный Марафон, Полумарафон и забег для новичков - 5 км. Таким образом фестиваль подходит всем.

В прошлых годах марафон был проведен в Осаке, Япония (2014); Лейпциге, Германия (2013); Ханое, Вьетнам (2012) и Йорк, Англия (2011).

В этом году Marathon Skills очень зрелищно пройдет в Екатеринбурге, Россия, он должен быть самым большим фестивалем бега.

Этот фестиваль привлек рекордное количество бегунов со всего мира. Особое внимание будет обращено на участников из Кении и Ямайки, поскольку мы надеемся увидеть победителя 2014 года.

Атмосфера праздника обещает развлечения для всех зрителей.";
    }
}
