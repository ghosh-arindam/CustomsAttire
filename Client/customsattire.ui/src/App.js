// import { useState } from "react";
import { Navigate, Routes, Route } from "react-router-dom";
// import Topbar from "./scenes/global/Topbar";
// import Sidebar from "./scenes/global/Sidebar";
import Dashboard from "./scenes/dashboard";
import Team from "./scenes/team";
import Vendor from "./scenes/supplierlocal";
import Bar from "./scenes/bar";
import Form from "./scenes/form";
import Line from "./scenes/line";
import Pie from "./scenes/pie";
import FAQ from "./scenes/faq";
import Customer from "./scenes/customer";
import Loginpage from "./scenes/loginpage";
import AddCustomer from "./scenes/customer/AddCustomer";
import Invoices from "./scenes/invoices";
import AddVendor from "./scenes/supplierlocal/AddSupplier";
import PurchaseOrders from "./scenes/purchaseorders";
import PurchaseMaster from "./scenes/purchaseorders/PurchaseMaster";
import { CssBaseline, ThemeProvider } from "@mui/material";
import { ColorModeContext, useMode } from "./theme";

function App() {
  const [theme, colorMode] = useMode();
  // const [isSidebar, setIsSidebar] = useState(true);
  const isAuth = true;
  return (
    <ColorModeContext.Provider value={colorMode}>
      <ThemeProvider theme={theme}>
        <CssBaseline />
        <div className="app">
          {/* <Sidebar isSidebar={isSidebar} /> */}
          <main className="content">
            {/* <Topbar setIsSidebar={setIsSidebar} /> */}
            <Routes>
              <Route path="/" element={<Loginpage />} />
              <Route path="/dashboard" element={<Dashboard />} />
              <Route
                path="/team"
                element={isAuth ? <Team /> : <Navigate to="/" />}
              />
              <Route path="/customer" element={<Customer />} />
              <Route path="/addCustomer" element={<AddCustomer />} />
              <Route path="/vendor" element={<Vendor />} />
              <Route path="/addvendor" element={<AddVendor />} />
              <Route path="/form" element={<Form />} />
              <Route path="/bar" element={<Bar />} />
              <Route path="/pie" element={<Pie />} />
              <Route path="/line" element={<Line />} />
              <Route path="/faq" element={<FAQ />} />
              <Route path="/posreport" element={<Invoices />} />
              {/* <Route path="/purchaseorders" element={<Purchase />} /> */}
              <Route path="/addfabric" element={<PurchaseMaster />} />
              <Route path="/purchaseorders" element={<PurchaseOrders />} />
            </Routes>
          </main>
        </div>
      </ThemeProvider>
    </ColorModeContext.Provider>
  );
}

export default App;
