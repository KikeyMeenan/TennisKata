var TennisGame1 = function (player1Name, player2Name) {
    this.m_score1 = 0;
    this.m_score2 = 0;
    this.player1Name = player1Name;
    this.player2Name = player2Name;
};

TennisGame1.prototype.wonPoint = function (playerName) {
    if (playerName === this.player1Name)
        this.m_score1 += 1;
    else
        this.m_score2 += 1;
};

var ScoreToWords = function (score) {
    return [
        "Love",
        "Fifteen",
        "Thirty",
        "Forty"
    ][score]
}

var isEvenScore = function (score1, score2) {
    return score1 === score2
}

var isAdvantageScore = function (score1, score2) {
    return score1 >= 4 || score2 >= 4
}

var GetEvenScoreInWords = function (score) {
    if (score >= 3) {
        return "Deuce"
    }
    return ScoreToWords(score) + "-All"
}

var GetAdvantageScoreInWords = function (minusResult) {
    if (minusResult === 1) return "Advantage player1";
    else if (minusResult === -1) return "Advantage player2";
    else if (minusResult >= 2) return "Win for player1";
    else return "Win for player2";
}

var GetScoreInWords = function (score1, score2) {
    return ScoreToWords(score1) + "-" + ScoreToWords(score2)
}

TennisGame1.prototype.getScore = function () {
    if (isEvenScore(this.m_score1, this.m_score2)) {
        return GetEvenScoreInWords(this.m_score1)
    }
    if (isAdvantageScore(this.m_score1, this.m_score2)) {
        return GetAdvantageScoreInWords(this.m_score1 - this.m_score2)
    }
    return GetScoreInWords(this.m_score1, this.m_score2)
};

if (typeof window === "undefined") {
    module.exports = TennisGame1;
}