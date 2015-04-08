public class Solution {
    public string IntToRoman(int num) {
        int m=0,d=0,c=0,l=0,x=0,v=0,ii=0;
        int tmp=num;
        string s=string.Empty;
        if(tmp/1000>0){
            m=tmp/1000;
            tmp=tmp%1000;
        }
        if(tmp/500>0){
            d=tmp/500;
            tmp=tmp%500;
        }
        if(tmp/100>0){
            c=tmp/100;
            tmp=tmp%100;
        }
        if(tmp/50>0){
            l=tmp/50;
            tmp=tmp%50;
        }
        if(tmp/10>0){
            x=tmp/10;
            tmp=tmp%10;
        }
        if(tmp/5>0){
            v=tmp/5;
            tmp=tmp%5;
        }
        ii=tmp;
        for(int i=0;i<m;i++){
            s=s+"M";
        }
        if(d!=0||c!=0){
            if(c!=4){
                for(int i=0;i<d;i++){
                    s=s+"D";
                }
                for(int i=0;i<c;i++){
                    s=s+"C";
                }
            }
            else{
                if(d==0){
                    s=s+"CD";
                }
                else{
                    s=s+"CM";
                }
            }
        }
        if(l!=0||x!=0){
            if(x!=4){
                for(int i=0;i<l;i++){
                    s=s+"L";
                }
                for(int i=0;i<x;i++){
                    s=s+"X";
                }
            }
            else{
                if(l==0){
                    s=s+"XL";
                }
                else{
                    s=s+"XC";
                }
            }
        }
       if(v!=0||ii!=0){
            if(ii!=4){
                for(int i=0;i<v;i++){
                    s=s+"V";
                }
                for(int i=0;i<ii;i++){
                    s=s+"I";
                }
            }
            else{
                if(v==0){
                    s=s+"IV";
                }
                else{
                    s=s+"IX";
                }
            }
        }
        return s;
    }
}