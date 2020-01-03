var TennisGame1 = function(player1Name, player2Name) {
    this.m_score1 = 0;
    this.m_score2 = 0;
    this.player1Name = player1Name;
    this.player2Name = player2Name;
};

TennisGame1.prototype.wonPoint = function(playerName) {
    if (playerName === this.player1Name)
        this.m_score1 += 1;
    else
        this.m_score2 += 1;
};

var ScoreToWords = function (score) {
    switch (score) {
        case 0:
            return "Love";
            break;
        case 1:
            return "Fifteen";
            break;
        case 2:
            return "Thirty";
            break;
        case 3:
            return "Forty";
            break;
    };
}

var GetEvenScoreInWords = function (score) {
    switch (score) {
        case 0:
            return "Love-All";
            break;
        case 1:
            return "Fifteen-All";
            break;
        case 2:
            return "Thirty-All";
            break;
        default:
            return "Deuce";
            break;
    }
}

var GetAdvantageScoreInWords = function (minusResult) {
    var minusResult = this.m_score1 - this.m_score2;
    if (minusResult === 1) return "Advantage player1";
    else if (minusResult === -1) return "Advantage player2";
    else if (minusResult >= 2) return "Win for player1";
    else return "Win for player2";
}

var GetScoreInWords = function(score1, score2) {
    var score = "";
    var tempScore = 0;
    for (var i = 1; i < 3; i++) {
        if (i === 1) tempScore = score1;
        else {
            score += "-";
            tempScore = score2;
        }
        score += ScoreToWords(tempScore);
    }
    return score
}

TennisGame1.prototype.getScore = function() {
    if (this.m_score1 === this.m_score2) {
        return GetEvenScoreInWords(this.m_score1)
    } else if (this.m_score1 >= 4 || this.m_score2 >= 4) {
        return GetAdvantageScoreInWords()
    } 
    return GetScoreInWords(this.m_score1, this.m_score2)
};

if (typeof window === "undefined") {
    module.exports = TennisGame1;
}