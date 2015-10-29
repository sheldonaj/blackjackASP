'use strict';

// Card directive
angular
  .module('game')
  .directive('gameCard', gameCard);


function gameCard() {
    var directive = {
        restrict: 'EA',
        templateUrl: 'templates/blackjack/game.card.html',
        scope: {
            cards: '='
        },
        controller: GameCardController,
        controllerAs: 'vm',
        bindToController: true
    }

    return directive;
}

GameCardController.$inject = ['GameHelper'];
function GameCardController(GameHelper) {
    var vm = this;

    vm.getCardImage = getCardImage;
    vm.getCardRank = getCardRank;

    function getCardImage(card) {
        return GameHelper.getCardSuitImage(card);
    }

    function getCardRank(card) {
        return GameHelper.getCardRank(card);
    }
}
