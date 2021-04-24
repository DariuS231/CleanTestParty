# Clean Test Party

Small project to demonstrate Error when Creating/Joining a Playfab Party in IOS.

- Unity Version: 2021.1.0f1
- Playfab SDK Version: 2.98.201027
- Playfab Party Plugin Version: 1.5.0.3-main.0-1.29.2021

## Prerequisite

1. Playfab Account
2. Playfab Title
3. Enable Party for the selected playfab Title

## Steps to reproduce the error

1. Open the project with Unity
2. Login to Playfab from the extension.
3. Select The Playfab Studio
4. Select the Playfab Title
5. Build solution for IOS
6. Open the new build with Xcode
7. Add a new Key to the 'Info.plist' file
    - Key: Privacy - Microphone Usage Description
    - Type: String
    - Value: Anything
7. Run Game on iPhone
8. See Logs on iPhone screen
