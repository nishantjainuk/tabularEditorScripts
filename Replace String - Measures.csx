/*Warning!  Take a backup copy first.  
This script will operate over every measure in the model. It is 
essential that your FromString and ToString are set to change only the
specific usage of the string that you need to change across the entire model.*/


var FromString = "Accrual";
var ToString = "Imbalance";
foreach (var m in Selected.Measures)
    {
        m.Expression = m.Expression.Replace(FromString,ToString);
        /* Cycle over all measures in model and replaces the 
           FromString with the ToString */
    }