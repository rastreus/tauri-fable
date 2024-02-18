module App

open Fable.Core
open Fable.Core.JsInterop
open Feliz

module Import =

    [<Erase>]
    type Tauri =
        [<Import("invoke", "@tauri-apps/api/tauri")>]
        static member invoke(cmd : string, ?invokeParams : obj) : JS.Promise<_> = jsNative

[<JSX.Component>]
let AppComponent () : JSX.Element =
    let greetMsg, setGreetMsg = React.useState ""
    let name, setName = React.useState ""

    /// Learn more about Tauri commands at https://tauri.app/v1/guides/features/command
    let greet () : unit =
        promise {
            let! (greetMsg : string) =
                Import.Tauri.invoke (
                    "greet",
                    createObj [
                        "name" ==> name
                    ]
                )
            setGreetMsg greetMsg
        }
        |> Promise.start

    let onSubmit (e : Browser.Types.Event) : unit =
        e.preventDefault()
        greet()

    let onChange (e : Browser.Types.Event) : unit =
        let value : string =
            !!e.target?value
        setName value

    JSX.jsx $"""
    import reactLogo from "./assets/react.svg";
    import fableLogo from "./assets/fable.svg";
    <div className="container">
      <h1>Welcome to Tauri!</h1>

      <div className="row">
        <a href="https://vitejs.dev" target="_blank">
          <img src="/vite.svg" className="logo vite" alt="Vite logo" />
        </a>
        <a href="https://tauri.app" target="_blank">
          <img src="/tauri.svg" className="logo tauri" alt="Tauri logo" />
        </a>
        <a href="https://reactjs.org" target="_blank">
          <img src={{reactLogo}} className="logo react" alt="React logo" />
        </a>
        <a href="https://fable.io" target="_blank">
          <img src={{fableLogo}} className="logo react" alt="Fable logo" />
        </a>
      </div>

      <p>Click on the Tauri, Vite, React, and Fable logos to learn more.</p>

      <form
        className="row"
        onSubmit={onSubmit}
      >
        <input
          id="greet-input"
          onChange={onChange}
          placeholder="Enter a name..."
        />
        <button type="submit">Greet</button>
      </form>

      <p>{greetMsg}</p>
    </div>
    """
