$(document).ready(function() {
    LoadMoney();
    LoadOverview();
})

function Format(n, c, d, t) {
    var c = isNaN(c = Math.abs(c)) ? 2 : c,
        d = d == undefined ? "." : d,
        t = t == undefined ? "," : t,
        s = n < 0 ? "-" : "",
        i = String(parseInt(n = Math.abs(Number(n) || 0).toFixed(c))),
        j = (j = i.length) > 3 ? j % 3 : 0;

    return s + (j ? i.substr(0, j) + t : "") + i.substr(j).replace(/(\d{3})(?=\d)/g, "$1" + t);
};

function LoadMoney() {
    let file = new XMLHttpRequest();
    file.open("GET", "balance.txt", true);
    file.onreadystatechange = function() {
        if (file.readyState === 4) {
            let balance = file.responseText;
            balance = Format(balance);
            balance = balance + " DKK";
            console.log("LoadMoney:", balance);
            $("#balanceAmount").text(balance);
        }
    }
    file.send();
}

function LoadOverview() {
    let file = new XMLHttpRequest();
    file.open("GET", "balance.json", true);
    file.onreadystatechange = function() {
        if (file.readyState === 4) {
            let data = JSON.parse(file.responseText);
            for (i = 0; i < data.length; i++) {
                let color;
                if (data[i]["type"] === "+") {
                    color = "#2ecc71";
                } else if (data[i]["type"] === "-") {
                    color = "#e74c3c";
                }
                let type = data[i]["type"];
                let amount = Format(data[i]["amount"]) + " DKK";
                let result = '<div id="activityList" style="color: ' + color + '"><span id="activityType">' + type + '</span><span id="activityAmount">' + amount + '</span></div>';
                $(".activity").prepend(result);
            } 
        }
    }
    file.send();
}

function GetMoney() {
    
    return money;
}

function AddMoney() {
    let amount = prompt("Hvor stort beløb vil du tilføje?");
    if (Number(amount)) {
        let file = new XMLHttpRequest();
        file.open("GET", "balance.txt", true);
        file.onreadystatechange = function() {
            if (file.readyState === 4) {
                let money = file.responseText;
                money = Number(money) + Number(amount);
                // let balanceFile = new XMLHttpRequest();
                let balanceFile = new FileReader();
                balanceFile.readAsText(money);
            }
        }
        file.send();
    }
}
