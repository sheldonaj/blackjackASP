'use strict';

//Helper factory for logic that does not need to be in the view model and does not need to be bindable to any view.
angular
	.module('game')
	.factory('GameHelper', GameHelper);

GameHelper.$inject = [];

function GameHelper() {
    return {
        getCardSuitImage: getCardSuitImage,
        getCardRank: getCardRank
    };

    // Map card suit to correct suit image.
    function getCardSuitImage(card) {
        var image = '/images/club.png';
        if (card.suit === 'H') {
            image = '/images/heart.png';
        } else if (card.suit === 'S') {
            image = '/images/spade.png';
        } else if (card.suit === 'D') {
            image = '/images/diamond.png';
        }
        return image;
    }

    // Map card rank to approriate face card value.
    function getCardRank(card) {
        if (card.rank === 1) {
            return 'A';
        } else if (card.rank === 11) {
            return 'J';
        } else if (card.rank === 12) {
            return 'Q';
        } else if (card.rank === 13) {
            return 'K';
        }
        return card.rank;
    }
}
