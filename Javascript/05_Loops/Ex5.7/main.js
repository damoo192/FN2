let leson = {
    predmet: "Math",
    dif: "Easy",
    Time: 30,
    doyou: "mandetory",
  };

  for (let prop in leson) {
    
    console.log (prop + ": " + leson[prop]);
  }