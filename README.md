# ImageToDesmosPolygon
A tool that helps to create polygons using images as reference for desmos

Avalible for Windows 10/11
Used for a future bad apple representation in Desmos

# Building
## Portable
This one can run in environments where there is no NET 8.0 installed
`dotnet publish VertexCreator.sln -r win-x64 -p:PublishSingleFile=true --self-contained true`

## Normal
Uses less storage space
`dotnet publish VertexCreator.sln`
