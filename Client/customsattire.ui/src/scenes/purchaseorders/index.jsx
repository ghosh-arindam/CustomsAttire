import React, { useState } from "react";
import { Box, Button, Select, MenuItem, Grid } from "@mui/material"; ////useTheme
// import { tokens } from "../../theme";
import useMediaQuery from "@mui/material/useMediaQuery";
import Header from "../../components/Header";
import Table from "@mui/material/Table";
import TableBody from "@mui/material/TableBody";
import TableCell from "@mui/material/TableCell";
import TableContainer from "@mui/material/TableContainer";
import TableHead from "@mui/material/TableHead";
import TableRow from "@mui/material/TableRow";
import Paper from "@mui/material/Paper";
import AddIcon from "@mui/icons-material/Add";
import { mockPurchaseOrder } from "./../../data/mockData";

// import { Formik } from "formik";
// import * as yup from "yup";

const PurchaseOrders = () => {
  //const theme = useTheme();
  //const colors = tokens(theme.palette.mode);
  const isNonMobile = useMediaQuery("(min-width: 600px)");
  const [selectedVendor, setSelectedVendor] = useState("");
  //const [selectedFabric, setSelectedFabric] = useState("");
  const TAX_RATE = 0.07;

  const handleVendorChange = (event) => {
    setSelectedVendor(event.target.value);
    //setSelectedFabric("");
    //setFabricDesc("");
  };
  function ccyFormat(num) {
    return `${num.toFixed(2)}`;
  }

  function priceRow(qty, unit) {
    return qty * unit;
  }

  function createRow(desc, qty, unit) {
    const price = priceRow(qty, unit);
    return { desc, qty, unit, price };
  }

  function subtotal(items) {
    return items.map(({ price }) => price).reduce((sum, i) => sum + i, 0);
  }

  const rows = [
    createRow("Paperclips (Box)", 100, 1.15),
    createRow("Paper (Case)", 10, 45.99),
    createRow("Waste Basket", 2, 17.99),
  ];

  const invoiceSubtotal = subtotal(rows);
  const invoiceTaxes = TAX_RATE * invoiceSubtotal;
  const invoiceTotal = invoiceTaxes + invoiceSubtotal;
  return (
    <Grid spacing={3} sx={{ flexGrow: 1 }} mx={4}>
      <Header title="PURCHASE ORDERS" subtitle="List of Purchase Orders Made" />
      <Box
        display="grid"
        gap="30px"
        gridTemplateColumns="repeat(3, minmax(0, 1fr))"
        sx={{
          "& > div": { gridColumn: isNonMobile ? undefined : "span 4" },
        }}
      >
        <Box sx={{ width: 1 / 2 }}>
          <Button
            variant="contained"
            color="primary"
            startIcon={<AddIcon />}
            size="medium"
            //onClick={() => navigate("/AddPurchase")}
          >
            Add Purchase Orders
          </Button>
        </Box>
        <Box sx={{ width: 1 / 4 }}></Box>
        <Box sx={{ mx: "auto", p: 1, mt: 1 }}>
          <Select
            sx={{
              align: "right",
              minWidth: 270,
              maxWidth: 470,
              pt: 1,
              "& .MuiNativeSelect-select": { pt: "8.5px" },
            }}
            value={selectedVendor}
            onChange={handleVendorChange}
          >
            <MenuItem value="">Select a vendor</MenuItem>
            {mockPurchaseOrder.map((data) => (
              <MenuItem key={data.id} value={data.vendorname}>
                {data.vendorname}
              </MenuItem>
            ))}
          </Select>
        </Box>
      </Box>
      <Box my={4}>
        <TableContainer component={Paper}>
          <Table sx={{ minWidth: 700 }} aria-label="spanning table">
            <TableHead>
              <TableRow>
                <TableCell align="left" colSpan={3}>
                  Fabric Code
                </TableCell>
                <TableCell align="center">Details</TableCell>
                <TableCell align="right">Price</TableCell>
              </TableRow>
              <TableRow>
                <TableCell align="left">Fabric Code</TableCell>
                <TableCell align="center">Desc</TableCell>
                <TableCell align="right">Qty.</TableCell>
                <TableCell align="right">Unit</TableCell>
                <TableCell align="right">Sum</TableCell>
              </TableRow>
            </TableHead>
            <TableBody>
              {rows.map((row) => (
                <TableRow key={row.desc}>
                  <TableCell>Fabric Code</TableCell>
                  <TableCell>{row.desc}</TableCell>
                  <TableCell align="right">{row.qty}</TableCell>
                  <TableCell align="right">{row.unit}</TableCell>
                  <TableCell align="right">{ccyFormat(row.price)}</TableCell>
                </TableRow>
              ))}

              <TableRow>
                <TableCell rowSpan={4} />
                <TableCell colSpan={3}>GrandTotal</TableCell>
                <TableCell align="right">
                  {ccyFormat(invoiceSubtotal)}
                </TableCell>
              </TableRow>
              <TableRow>
                <TableCell>Tax</TableCell>
                <TableCell align="right" colSpan={2}>
                  {`${(TAX_RATE * 100).toFixed(0)} %`}
                </TableCell>
                <TableCell align="right" colSpan={2}>
                  {ccyFormat(invoiceTaxes)}
                </TableCell>
              </TableRow>
              <TableRow>
                <TableCell colSpan={3}>Total</TableCell>
                <TableCell align="right">{ccyFormat(invoiceTotal)}</TableCell>
              </TableRow>
            </TableBody>
          </Table>
        </TableContainer>
      </Box>
    </Grid>
  );
};

export default PurchaseOrders;
