$(document).ready(function () {

    function animate(obj, initVal, lastVal, duration) {

        let startTime = null;

        let currentTime = Date.now();

        const step = (currentTime) => {

            if (!startTime) {
                startTime = currentTime;
            }

            const progress = Math.min((currentTime - startTime) / duration, 1);

            obj.innerHTML = Math.floor(progress * (lastVal - initVal) + initVal);

            if (progress < 1) {
                window.requestAnimationFrame(step);
            } else {
                window.cancelAnimationFrame(window.requestAnimationFrame(step));
            }
        };
        window.requestAnimationFrame(step);
    }
    let text1 = document.getElementById('0101');
    let text2 = document.getElementById('0102');
    let text3 = document.getElementById('0103');
    let text4 = document.getElementById('0104');

    animate(text1, 0, 945, 2000);
    animate(text2, 0, 1280, 2000);
    animate(text3, 0, 578, 2000);
    animate(text4, 0, 26, 2000);

   
}) 