open Saturn
open Giraffe
open Routing

let app = application {
    use_router Routing.appRouter
}

run app