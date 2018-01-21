using System;

public class Security{
    public string InstrumentId; 
}

public class SecurityRepository{
    private Dictionary<string,List<Security>> SecurityDict;
    public SecurityRepository(Security[] Securities){
        SecurityDict = new Dictionary<string,List<Security>>();
        foreach (var item in Securities)
        {
            if(SecurityDict.ContainsKey(item.InstrumentId)){
                SecurityDict[item.InstrumentId].Add(item);
            }else{
                var tmpList = new List<Security>()
                tmpList.Add(item);
                SecurityDict.Add(item.InstrumentId,list);
            }
        }
    }

    public IEnumerable<Security> GetSecurities(string instrumentId){
        if(SecurityDict.ContainsKey(instrumentId)){
            return SecurityDict[instrumentId];
        }
        else{
            return null;
        }
    }
}