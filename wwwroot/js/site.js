// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
(function () {
  // Page fade-in on load
  document.addEventListener('DOMContentLoaded', function () {
    var wrapper = document.getElementById('page-wrapper');
    if (wrapper) {
      requestAnimationFrame(function(){ wrapper.classList.remove('opacity-0'); wrapper.classList.add('opacity-100'); });
    }
  });

  // Intercept navigations for fade-out then navigate
  document.addEventListener('click', function (e) {
    var a = e.target.closest('a');
    if (!a) return;
    var href = a.getAttribute('href');
    if (!href || href.startsWith('#') || a.target === '_blank' || href.startsWith('mailto:') || href.startsWith('tel:')) return;

    var sameOrigin = a.origin === window.location.origin;
    if (!sameOrigin) return;

    var wrapper = document.getElementById('page-wrapper');
    if (!wrapper) return;
    e.preventDefault();
    wrapper.classList.remove('opacity-100');
    wrapper.classList.add('opacity-0');
    setTimeout(function(){ window.location.href = href; }, 180);
  });
})();
