$(document).ready(function () {

		const containerr = document.querySelector('.containerr');
		const cards = document.querySelector('.cards');

		let isPressedDown = false;
		let cursorXSpace;

		containerr.addEventListener('mousedown', (e) => {
			isPressedDown = true;
		cursorXSpace = e.offsetX - cards.offsetLeft;

		});

		window.addEventListener('mouseup', () => {
			isPressedDown = false;
		});

		containerr.addEventListener('mousemove', (e) => {
			if (!isPressedDown) return;
		e.preventDefault();
		cards.style.left = `${e.offsetX - cursorXSpace}px`
		boundCards();

		});

		function boundCards() {
			const containerr_rect = containerr.getBoundingClientRect();
		const cards_rect = cards.getBoundingClientRect();

			if (parseInt(cards.style.left) > 0) {
			cards.style.left = 0;
			} else if (cards_rect.right < containerr_rect.right) {
			cards.style.left = `-${cards_rect.width - containerr_rect.width}px`;
			}
		}

})