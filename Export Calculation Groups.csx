//More information can be found here https://docs.tabulareditor.com/Useful-script-snippets.html#export-object-properties-to-a-file
var tsv = "Name" + "\t" + "Expression" + "\t" + "Expression Format" + "\n";
foreach (var m in Selected.CalculationItems)
    {
        var mFormatStringExpression = m.FormatStringExpression;
        if (mFormatStringExpression == null){
            mFormatStringExpression = "";
        }
        tsv = tsv + m.Name + "\t" + m.Expression.Replace("\n", "") + "\t" + mFormatStringExpression.Replace("\t", "") + "\n";
    }
// Export properties for the currently selected objects:

SaveFile("C:\\Users\\datanomy.uk\\Downloads\\Exported Properties 1.tsv", tsv);


// Imports and applies the properties in the specified file:
//var tsv = ReadFile("C:\\Users\\datanomy.uk\\Downloads\\Exported Properties 1.tsv");
//ImportProperties(tsv);