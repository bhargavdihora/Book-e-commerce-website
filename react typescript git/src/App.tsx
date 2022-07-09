import React from "react";
import { ThemeProvider } from "@material-ui/core/styles";
import { BrowserRouter } from "react-router-dom";
import { ToastContainer } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";
import Header from "./component/header";
import Footer from "./component/footer";
import "./assets/css/style.css";
import { theme } from "./utils/theme";
import MainNavigation from "./component/MainNavigation";
import { AuthWrapper } from "./context/auth";
import { CartWrapper } from "./context/cart";


function App() {
  return (
    <ThemeProvider theme={theme}>
      <React.Suspense fallback={<></>}>
        <BrowserRouter>
        <AuthWrapper>
          <CartWrapper>
          <div className="wrapper">
          <Header />
            <main>
              <MainNavigation />
            </main>
            <Footer />
          </div>
          </CartWrapper>
          </AuthWrapper>
          <ToastContainer />
        </BrowserRouter>
      </React.Suspense>
    </ThemeProvider>
  );
}

export default App;