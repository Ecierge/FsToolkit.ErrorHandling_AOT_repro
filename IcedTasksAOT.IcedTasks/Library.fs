namespace IcedTasksAOT.IcedTasks

open System.Threading.Tasks
open FsToolkit.ErrorHandling
open IcedTasks

module Say =

    let method1 () = valueTask {
        return 0
    }

    let method2 () = ValueTask.toUnit <| valueTask {
        ()
    }

    let method3 () = cancellableValueTask {
        return 0
    }

    let method4 () = CancellableValueTask.toUnit <| cancellableValueTask {
        ()
    }

    let method5 () : CancellableTaskValidation<int, string> = cancellableTaskValidation {
        return 0
    }
