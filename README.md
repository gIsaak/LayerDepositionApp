# Slapping App
This project offers a single UI to interface all the components
of the slapping station.
A single Windows Form App groups together the controls
of the different hardware components in the setup.

The (interfaced) hardware currently in use consists of:
- Camera (Nikon D5200)
- Sample stage controller (Mechonics CU30)
- Fiber motor controller (Thorlabs KDC101 DC Servo Drive)

## Overview
The Windows Form App is developed within a Visual Studio solution.
The Solution contains different Projects that can be run independently.
 


### Camera (Nikon D5200)
In order to use the camera it is necessary to download the correct SDK
from Nikon at https://sdk.nikonimaging.com/apply/.
The SKD contains the following files:
- Type0009.md3
- NkdPTP.dll

These need to be present in the same folder as the Project executable 
(.exe with the same name as trhe project),
usually located in the /bin folder (or one of its subdirectories)

The Project NikonWrapper contains a C# library 
used to wrap the functionality of the native Nikon MAID SDK.
Any other project can use these functionality by adding a reference to NikonWrapper.
More information can be found at https://sourceforge.net/projects/nikoncswrapper/.


### Sample stage controller (Mechonics CU30)
Installation of the Mechonics CU30 controller software is required. 
This can easily be dony by connection the controller to the PC with a USB cable.
In order to use the controller within a Windows Form the following are required:
- CU30.dll
- CU30Interface.cs
  
CU30.dll needs to be present in the same folder as the Project executable.
CU30Interface.cs needs to be referenced (or its source code pasted into the target project)

Both can be found at

    C:\Program Files\MechonicsStages\Software Controller CU30\CU30_C#_x64(\bin)

More documentation is provided at 

    C:\Program Files\MechonicsStages\Software Controller CU30

### Fiber motor controller (Thorlabs KDC101 DC Servo Drive)
Installation of Thorlabs Kinesis software is required. 




