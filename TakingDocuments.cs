using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace SqlQuery
{
    public class TakingDocuments
    {




        private void CloseAndSaveDocument(WordprocessingDocument wordDocument)
        {
            wordDocument.MainDocumentPart.Document.Save();
            wordDocument.Close();
        }


        private void HighLightText(Paragraph paragraph, string text)
        {
            string textOfRun = string.Empty;
            var runCollection = paragraph.Descendants<Run>();
            Run runAfter = null;

           
            foreach (Run run in runCollection)
            {
                textOfRun = run.GetFirstChild<Text>().Text;
                if (textOfRun.Contains(text))
                {
                
                    run.GetFirstChild<Text>().Text = textOfRun.Replace(text, "");
                    runAfter = run;
                    break;
                }
            }

          
            Run HighLightRun = new Run();
            RunProperties runPro = new RunProperties();
            RunFonts runFont = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold = new Bold();
            DocumentFormat.OpenXml.Wordprocessing.Color color = new DocumentFormat.OpenXml.Wordprocessing.Color() { Val = "FF0000" };
            FontSize fontSize = new FontSize() { Val = "12" };
            FontSizeComplexScript fontSizeComplex = new FontSizeComplexScript() { Val = "12" };
            Text runText = new Text() { Text = text };

            runPro.Append(runFont);
            runPro.Append(bold);
            runPro.Append(color);
            runPro.Append(fontSize);
            runPro.Append(fontSizeComplex);

            HighLightRun.Append(runPro);
            HighLightRun.Append(runText);

     
            paragraph.InsertAfter(HighLightRun, runAfter);
        }


        private bool hasParticularText(Paragraph paragraph, string text)
        {
            bool has = false;
            string textOfRun = string.Empty;
            var runCollection = paragraph.Descendants<Run>();
            foreach (Run run in runCollection)
            {
                textOfRun = run.GetFirstChild<Text>().Text;
                if (textOfRun.Contains(text))
                {
                    has = true;
                    break;
                }
            }
            return has;
        }
        public void WriteToWordDoc(string filepath, string txt)
        {
     
            using (WordprocessingDocument wordprocessingDocument =
                WordprocessingDocument.Open(filepath, true))
            {
       
                Body body = wordprocessingDocument.MainDocumentPart.Document.Body;

           
                Paragraph para = body.AppendChild(new Paragraph());
                Run run = para.AppendChild(new Run());
                run.AppendChild(new Text(txt));
            }
        }

        public void CreateWordprocessingDocument(string filepath, string text)
        {

            using (WordprocessingDocument wordDocument =
                WordprocessingDocument.Create(filepath, WordprocessingDocumentType.Document))
            {
    
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();

     
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());
                Paragraph para = body.AppendChild(new Paragraph());
                Run run = para.AppendChild(new Run());
                run.AppendChild(new Text(text));
            }
        }
        public void AddTable(string fileName, string[,] data)
        {
            using (var document = WordprocessingDocument.Open(fileName, true))
            {

                var doc = document.MainDocumentPart.Document;

                Table table = new Table();

                TableProperties props = new TableProperties(
                    new TableBorders(
                    new TopBorder
                    {
                        Val = new EnumValue<BorderValues>(BorderValues.Single),
                        Size = 0
                    },
                    new BottomBorder
                    {
                        Val = new EnumValue<BorderValues>(BorderValues.Single),
                        Size = 0
                    },
                    new LeftBorder
                    {
                        Val = new EnumValue<BorderValues>(BorderValues.Single),
                        Size = 0
                    },
                    new RightBorder
                    {
                        Val = new EnumValue<BorderValues>(BorderValues.Single),
                        Size = 0
                    },
                    new InsideHorizontalBorder
                    {
                        Val = new EnumValue<BorderValues>(BorderValues.Single),
                        Size = 0
                    },
                    new InsideVerticalBorder
                    {
                        Val = new EnumValue<BorderValues>(BorderValues.Single),
                        Size = 0
                    }));

                table.AppendChild<TableProperties>(props);

                for (var i = 0; i <= data.GetUpperBound(0); i++)
                {
                    var tr = new TableRow();
                    for (var j = 0; j <= data.GetUpperBound(1); j++)
                    {
                        var tc = new TableCell();
                        tc.Append(new Paragraph(new Run(new Text(data[i, j]))));

                     
                        tc.Append(new TableCellProperties(
                            new TableCellWidth { Type = TableWidthUnitValues.Auto }));

                        tr.Append(tc);
                    }
                    table.Append(tr);
                }
                doc.Body.Append(table);
                doc.Save();
            }
        }

        public void OpenDocument(string filepath)
        {
            WordprocessingDocument wordprocessingDocument =
                WordprocessingDocument.Open(filepath, true);
            wordprocessingDocument.Close();

        }
        public void OpenAndAddTextToWordDocument(string filepath, string txt)
        {
        
            WordprocessingDocument wordprocessingDocument =
                WordprocessingDocument.Open(filepath, true);

            Body body = wordprocessingDocument.MainDocumentPart.Document.Body;


            Paragraph para = body.AppendChild(new Paragraph());
            Run run = para.AppendChild(new Run());
            run.AppendChild(new Text(txt));

        
            wordprocessingDocument.Close();
        }
    }
}
