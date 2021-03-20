export const usuarioAutenticado = () => localStorage.getItem('techcycle') !==null;

export const parseJwt = () => {
    var base64 = localStorage.getItem('techcycle').split('.')[1];
    return JSON.parse(window.atob(base64));
}