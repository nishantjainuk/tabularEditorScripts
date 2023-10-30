//More information can be found here https://docs.tabulareditor.com/Useful-script-snippets.html#export-object-properties-to-a-file

// Export properties for the currently selected objects:
var tsv = ExportProperties(Selected);
SaveFile("C:\\Users\\datanomy.uk\\Downloads\\Exported Properties 1.tsv", tsv);


// Imports and applies the properties in the specified file:
var tsv = ReadFile("C:\\Users\\datanomy.uk\\Downloads\\Exported Properties 1.tsv");
ImportProperties(tsv);