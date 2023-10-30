/*Warning!  Take a backup copy first.  
This script will operate over every measure in the model. It is 
essential that your FromString and ToString are set to change only the
specific usage of the string that you need to change across the entire model.*/



foreach (var m in Selected.Measures)
    {
        var measureName = m.Name.Replace("Sales Forecast - ","");
        //number of tabs for the 1st line
        var tabs1 = "                ";
        //number of tabs for the 2nd lines
        var tabs2 = tabs1 + "    ";
        var FromString = tabs1 + "SWITCH (\n" + tabs2 + "[department],\n" + tabs2 + "\"SME\", [" + measureName + " SME pkWh] * [Power Sales Forecast],\n" + tabs2 + "\"KAM\", [" + measureName + " KAM pkWh] * [Power Sales Forecast],\n" + tabs2 + "BLANK ()\n" + tabs1 + ")";
        var ToString = tabs1 + "[" + measureName + " SME pkWh] * [Power Sales Forecast]";
        m.Expression = m.Expression.Replace(FromString,ToString);
        /* Cycle over all measures in model and replaces the 
           FromString with the ToString */
    }