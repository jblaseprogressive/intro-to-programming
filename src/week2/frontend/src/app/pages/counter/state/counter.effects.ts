import { Injectable } from "@angular/core";
import { Actions, concatLatestFrom, createEffect, ofType } from "@ngrx/effects";
import { map, tap } from "rxjs";
import { CounterEvents } from "./counter.actions";
import { counterFeature } from ".";

@Injectable({
  providedIn: "root",
})
export class CounterEffects {
  saveCounterState$ = createEffect(
    () =>
      this.actions$.pipe(
        ofType(
          CounterEvents.incrementClicked,
          CounterEvents.decrementClicked,
          CounterEvents.resetClicked,
          CounterEvents.countByChanged,
        ),
        concatLatestFrom(() =>
          this.store.select(counterFeature.selectCounterState),
        ),
        map(([_, counterState]) => {
          localStorage.setItem("counterState", JSON.stringify(counterState));
        }),
      ),
    { dispatch: false },
  );
  //   logEmAll$ = createEffect(
  //     () =>
  //       this.actions$.pipe(
  //         tap((action) => console.log(`Got an action of the ${action.type}`)),
  //       ),
  //     { dispatch: false },
  //   );

  constructor(
    private readonly actions$: Actions,
    private readonly store: Store,
  ) {}
}
