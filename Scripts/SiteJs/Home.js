const prevBtn = document.querySelector('.prev');
const nextBtn = document.querySelector('.next');
const slideshowContainer = document.querySelector('.slideshow-container');

let slideIndex = 0;

prevBtn.addEventListener('click', () => {
    slideIndex--;
    if (slideIndex < 0) {
        slideIndex = 1;
    }
    slideshowContainer.style.transform = `translateX(-${slideIndex * 50}%)`;
});

nextBtn.addEventListener('click', () => {
    slideIndex++;
    if (slideIndex > 1) {
        slideIndex = 0;
    }
    slideshowContainer.style.transform = `translateX(-${slideIndex * 50}%)`;
});