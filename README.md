# BAR DANCE WORLD — iOS Online Prototype v0.2

This is an upgraded Unity 6 prototype foundation, not a finished online game or an IPA.
Unity Editor target: 6000.0.23f1.

## Included
- Procedural 3D neon nightclub scene generator (no third-party assets required).
- Editor menu to create and save a playable prototype scene.
- Basic player profile and coin manager.
- iOS build preparation checklist.
- Explicit online multiplayer implementation plan.

## Create the scene
1. Open this folder as a Unity project using Unity 6000.0.23f1 or a compatible Unity 6 editor.
2. Wait for package import.
3. In Unity, choose `BAR DANCE WORLD > Create Prototype Scene`.
4. Save the generated scene at `Assets/Scenes/BarDanceWorld.unity`.
5. Open the scene and press Play.

The scene uses generated primitives and Unity lights. It is a visual prototype, not final photorealistic art.

## Online status — important
Online multiplayer is NOT implemented in this prototype. A real online release still needs a networking stack (for example Netcode for GameObjects + Unity Transport), Lobby/Relay or dedicated servers, player authentication, matchmaking, reconnect handling, server-authoritative scoring, moderation, and load testing. Do not advertise multiplayer as working until these are implemented and tested with multiple devices.

## iOS requirements
- iOS builds must be produced on macOS with Xcode, either locally or by a supported cloud build service.
- Configure a unique Bundle Identifier in Player Settings.
- Set iOS minimum version based on the chosen Unity packages/devices.
- Apple signing certificate and provisioning profile are required for device/TestFlight distribution.
- TestFlight/App Store distribution requires Apple Developer Program membership.
- Uploading source code to GitHub does not itself create an iOS app.

## GitHub source layout
Keep the Unity project root at repository root:
- Assets/
- Packages/
- ProjectSettings/

Do not upload only the ZIP file. Exclude `Library/`, `Temp/`, `Obj/`, `Build/`, and `.DS_Store`.
