using Fluxor;

namespace FluxorTest.Components.Pages
{
    // STATE
    [FeatureState]
    public record CounterState
    {
        public required int Count { get; init; }
    }

    // ACTIONS
    public record CountIncremented;


    // REDUCERS
    public static class Reducers
    {
        [ReducerMethod]
        public static CounterState OnCountIncremented(CounterState state, CountIncremented action) =>
            state with { Count = state.Count + 1 };
    }
}
