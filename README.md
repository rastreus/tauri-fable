# Tauri + Fable (React)

![Tauri Fable](./img/tauri-fable-dark.png#gh-dark-mode-only)
![Tauri Fable](./img/tauri-fable-light.png#gh-light-mode-only)

This template should help get you started developing with Tauri and Fable (React) in Vite.

_This template is a simple, minimalistic port of the `pnpm create tauri-app` React template for Fable._

## Recommended IDE Setup

- [VS Code](https://code.visualstudio.com/) + [Tauri](https://marketplace.visualstudio.com/items?itemName=tauri-apps.tauri-vscode) + [rust-analyzer](https://marketplace.visualstudio.com/items?itemName=rust-lang.rust-analyzer) + [Ionide for F#](https://marketplace.visualstudio.com/items?itemName=ionide.ionide-fsharp)

### Dependencies

* [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
    + [Fable](https://fable.io)
    + [Paket](https://fsprojects.github.io/Paket/)
* [Node.js (20.x LTS)](https://nodejs.org/en)
    + [pnpm](https://pnpm.io)
* [Rust](https://www.rust-lang.org)    

### Development

* Install .NET dependencies:
    + `dotnet tool restore`
    + `dotnet paket install`
* Install JavaScript dependencies:
    + `corepack enable`
    + `corepack use pnpm@latest`
    + `pnpm install`
* Build: `dotnet build src/Src.fsproj`
* Dev: `pnpm tauri dev`
