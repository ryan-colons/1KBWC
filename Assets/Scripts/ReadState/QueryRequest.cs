using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueryRequest {
    public Query Query { get; set; }
    public QueryFilter Filter { get; set; }

    public RunTimeValue Target_Ref { get; set; }
    public SecondaryQuery SecondaryQuery { get; set; }

    public QueryRequest(Query q, RunTimeValue target) {
        Query = q;
        Target_Ref = target;
    }

    public QueryRequest(Query q, object o) {
        Query = q;
        Target_Ref = new RunTimeValue(o);
    }
}

public enum LIST_QUERY { SIZE, LIST, RAND_ITEM };
public class SecondaryQuery {
    public LIST_QUERY QueryType { get; set; }
}