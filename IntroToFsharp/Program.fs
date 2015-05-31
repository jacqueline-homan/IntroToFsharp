// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
open System.Windows.Forms

type Artist = { Name:string; Song:string; Year:int} // This is called a record

let testData =
    [|
        { Name = "Shaun Cassidy"; Song = "Da Doo Run Run"; Year = 1977};
        { Name = "Toni Tenille"; Song = "You Never Done It Like That" ; Year = 1978};
        { Name = "Linda Ronstadt"; Song = "You're No Good"; Year = 1976};

    |]

let form = new Form(Text = "F# Windows Form")

let dataGrid = new DataGridView(Dock=DockStyle.Fill, DataSource = testData)
form.Controls.Add(dataGrid)

Application.Run(form)

[<EntryPoint>]
let main argv = 
    printfn "Hello world!" 
    printfn "How are you today?"
    let response = System.Console.ReadLine()
    printfn "Great to hear you're %s" response
    0 // return an integer exit code

