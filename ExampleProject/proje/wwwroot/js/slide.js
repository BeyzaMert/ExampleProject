<script type="text/javascript">
    var slides = document.querySelectorAll('.slide');
    var btns = document.querySelectorAll('.btn');
    let currentSlide = 1;

    //Javascript for image slider manual navigation
    var manualNav = function (manual) {
        slides.forEach((slide) => {
            slide.classList.remove('active');

            btns.forEach((btn) => {
                btn.classList.remove('active');
            });
        })};


    slides[manual].classList.add('active');
    btns[manual].classList.add('active');
    }

    btns.forEach((btn, i) => {
        btn.addEventListener("click", () => {
            manualNav(i);
            currentSlide = i;
        });
    });

    //Javascript for image slider autoplay navigation
    var repeat = function (activeClass) {
        let active = document.getElementsByClassName('active');
    let i = 1;

        var repeater = () => {
        setTimeout(function () {
            [...active].forEach((activeSlide) => {
                activeSlide.classList.remove('active');
            });


            slides[i].classList.add('active');
            btns[i].classList.add('active');
            i++;


            if (slides.length == i) {
                i = 0;
            }
            if (i >= slides.length) {
                return;
            }
            repeater();
        }, 10000);
        }
    repeater();
    }
    repeat();


    function animate(obj, initVal, lastVal, duration) {
        let startTime = null;


    let currentTime = Date.now();

        //pass the current timestamp to the step function
        const step = (currentTime) => {

            //if the start time is null, assign the current time to startTime
            if (!startTime) {
        startTime = currentTime;
            }

    //calculate the value to be used in calculating the number to be displayed
    const progress = Math.min((currentTime - startTime) / duration, 1);

    //calculate what to be displayed using the value gotten above
    obj.innerHTML = Math.floor(progress * (lastVal - initVal) + initVal);

    //checking to make sure the counter does not exceed the last value (lastVal)
    if (progress < 1) {
        window.requestAnimationFrame(step);
            } else {
        window.cancelAnimationFrame(window.requestAnimationFrame(step));
            }
        };
    //start animating
    window.requestAnimationFrame(step);
    }
    let text1 = document.getElementById('0101');
    let text2 = document.getElementById('0102');
    let text3 = document.getElementById('0103');
    let text4 = document.getElementById('0104');


    const load = () => {
        animate(text1, 0, 945, 2000);
    animate(text2, 0, 1280, 2000);
    animate(text3, 0, 578, 2000);
    animate(text4, 0, 26, 2000);
    }



</script>
