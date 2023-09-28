import { Injectable } from "@angular/core";
import { Actions, concatLatestFrom, createEffect, ofType } from "@ngrx/effects";
import { map } from "rxjs/operators"; // Import pipeable operators
import { CounterEvents } from "./counter.actions";
import * as counterFeature from "./counter.reducer"; // Import your reducer or state
import { Store } from "@ngrx/store"; // Import Store from @ngrx/store

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

  constructor(
    private readonly actions$: Actions,
    private readonly store: Store
  ) {}
}
