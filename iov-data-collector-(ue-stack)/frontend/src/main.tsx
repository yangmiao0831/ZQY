import { StrictMode } from 'react';
import { createRoot } from 'react-dom/client';
import App from './App.tsx';
import './index.css';

// Safety wrapper for cross-origin script errors and unhandled promise rejections
window.addEventListener('error', (event) => {
  if (event.message === 'Script error.' || !event.filename || event.filename.includes('amap.com')) {
    event.preventDefault();
    event.stopPropagation();
    console.warn('[Main] Suppressed cross-origin/external script error:', event.message);
    return true;
  }
});

window.addEventListener('unhandledrejection', (event) => {
  console.warn('[Main] Suppressed unhandled rejection:', event.reason);
  event.preventDefault();
});

createRoot(document.getElementById('root')!).render(
  <StrictMode>
    <App />
  </StrictMode>
);
