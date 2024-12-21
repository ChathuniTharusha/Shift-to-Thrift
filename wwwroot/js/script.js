window.addEventListener('scroll', () => {
    const banner = document.querySelector('.banner-image');
    const scrollY = window.scrollY;
    banner.style.transform = `translateY(${scrollY * 0.5}px)`; // Adjust the speed (0.5) for the desired sliding effect
});
