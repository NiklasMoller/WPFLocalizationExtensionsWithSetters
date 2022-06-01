# WPFLocalizationExtensionsWithSetters

This project attempts to use [WPFLocalizeExtension](https://github.com/XAMLMarkupExtensions/WPFLocalizeExtension) with Setters.

## Use Case
The applications handles two different types of user. These are Patients suffereing from Phantom Limb Pain (PLP) and Spinal Chord Injury (SCI). 
The UI shall adapt its text with DataTriggers depending on which Patient is using the application. For example, it display "Phantom Limb Pain" on LOGIN for PLP users, while it displays "Spinal Chord Injury" for SCI users.

Further, the application shall perform Localization and translate the text. For example, "Phantom Limb Pain" shall for Swedish users be displayed "Fantomsmärtor".  

The configurations for different Patient Types is read from an XML-file:

```
<?xml version=\"1.0\" encoding=\"utf-8\" ?>
<configurations>
<PatientType>PLP</PatientType>
</configurations>
```
