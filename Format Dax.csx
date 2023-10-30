
foreach(var m in Selected.Measures)
{
    m.FormatDax();
}

foreach(var m in Selected.CalculationItems)
{
    m.FormatDax();
}

