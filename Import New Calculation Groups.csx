var targetTable = Model.AddCalculationGroup("Summary Metrics1");  // Name of the table that should hold the measures
var measureMetadata = ReadFile(@"C:\Users\datanomy.uk\Downloads\Exported Properties 1.tsv");   // c:\Test\MyMeasures.tsv is a tab-separated file with a header row and 3 columns: Name, Description, Expression
// Delete all measures from the target table that have an "AUTOGEN" annotation with the value "1":
/*foreach(var m in targetTable.CalculationItem.Where(m => m.GetAnnotation("AUTOGEN") == "1").ToList())
{
    m.Delete();
}*/

// Split the file into rows by CR and LF characters:
var tsvRows = measureMetadata.Split(new[] {'\r','\n'},StringSplitOptions.RemoveEmptyEntries);

// Loop through all rows but skip the first one:
foreach(var row in tsvRows.Skip(1))
{
    var tsvColumns = row.Split('\t');     // Assume file uses tabs as column separator
    var name = tsvColumns[0];             // 1st column contains measure name
    //var description = tsvColumns[1];      // 2nd column contains measure description
    //var expression = tsvColumns[2];       // 3rd column contains measure expression

    // This assumes that the model does not already contain a measure with the same name (if it does, the new measure will get a numeric suffix):
    var measure = targetTable.AddCalculationItem(name);
    //measure.Description = description;
    //measure.Expression = expression;
    //measure.SetAnnotation("AUTOGEN", "1");  // Set a special annotation on the measure, so we can find it and delete it the next time the script is executed.
}