
# Some Guides for WinForms

#### Removing extra events in Visual Studio 2022 WinForms

---

Well I figured out how to remove the extra events without deleting the label or whatever is being removed.

1. Open the Form1.cs designer.
2. Click on the item to remove an event from, press F4 on it to bring up the properties window.
3. Click on the lighting bolt to bring up the events, and remove the value from the 'Click' event.
4. Remove the function in Form1.cs (The form code file)