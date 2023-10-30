var targetTable = Model.Tables["Data"]; 
// Creates a SUM measure for every currently selected column and hide the column.
foreach(var c in Selected.CalculationItems)
{
    var newMeasure = targetTable.AddMeasure(
        c.Name,                    // Name
        c.Expression.Replace("SELECTEDMEASURE ()", "[Value]")    // DAX expression
        //c.DisplayFolder                        // Display Folder
    );
    
    // Set the format string on the new measure:
    newMeasure.FormatString = c.FormatStringExpression;

    // Provide some documentation:
    //newMeasure.Description = "This measure is the sum of column " + c.DaxObjectFullName;

    // Hide the base column:
    //c.IsHidden = true;
}