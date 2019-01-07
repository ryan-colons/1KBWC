public class Q_Flag : Query {
    public override QueryResult Run(RunTimeValue target, GameController gameController){
        string key = (string) target.Evaluate();
        return new QueryResult(gameController.Variables.IsFlag(key));
    }
}