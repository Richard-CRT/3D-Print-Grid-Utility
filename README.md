# 3D Print Grid Utility
Utility to create/modify/render the .grid file(s) created by smoothieware firmware. Please bear in mind that it was made for a Tevo Little Monster printer, and I cannot guarantee that it will function at all for any other printers, although it is more likely to work for other delta printers.
If auto-callibration is failing you, you might find that manually adjusting the/creating your own .grid file is the easiest solution.

Where possible, the elements of the form have tool-tips attached which attempt to explain their function, just hover over them. Please note that there are several possible interactions with the form that will clear unsaved changes without warning.

### Grid Modifier
This part of the utility can render a supplied .grid file as a heatmap of high and low points.
Because the software was made to work with a Tevo Little Monster it marks the regions that are outside the radius with bold text.
It also does not take the values outside the circle into account for the maximum-minimum points of the heatmap.

![Screenshot of the Grid Modifier function of the utility](https://raw.githubusercontent.com/Richard-CRT/3D-Print-Grid-Utility/master/GridModifier.png)

### Radial Generator
This part of the utility can generate a .grid file as a function of a net of nodes that each have height values.
This function is specifically useful for printers with circular beds, and can be used to create sufficiently accurate grid files without individually calculating/setting values of hundreds of grid points.

![Screenshot of the Grid Modifier function of the utility](https://raw.githubusercontent.com/Richard-CRT/3D-Print-Grid-Utility/master/RadialGenerator.png)
