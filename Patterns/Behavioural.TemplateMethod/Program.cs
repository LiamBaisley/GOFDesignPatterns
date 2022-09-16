using Behavioural.TemplateMethod;

AbstractDocument pdf = new PDFDocument();
pdf.Print();

AbstractDocument html = new HTMLDocument();
html.Print();