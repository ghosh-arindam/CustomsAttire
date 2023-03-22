// import React, { useState } from "react";
import React, { useRef, useState, useEffect } from "react";
//import { v4 as uuid } from "uuid";

// import { Calendar } from 'react-big-calendar';
//import moment from "moment";
// import 'react-big-calendar/lib/css/react-big-calendar.css';
// import DatePicker from 'react-datepicker';

import { mockDataTeam } from "../../data/mockData";
import {
  Table,
  TableBody,
  TableCell,
  TableContainer,
  TableHead,
  TableRow,
  Paper,
  Select,
  MenuItem,
  FormControl,
  InputLabel,
  Button,
  TextField,
} from "@mui/material";
// import { makeStyles } from "@material-ui/core/styles";
// import { DatePicker } from "@material-ui/pickers";

const VendorTable = () => {
  const [selectId, setSelectedId] = useState(null);
  const [selectedDate, setSelectedDate] = useState(null);

  const [selectedVendor, setSelectedVendor] = useState(null);
  const [showOnlyOneRow, setShowOnlyOneRow] = useState(false);
  const [advance, setAdvance] = useState(0);
  // const [due, setDue] = useState(0);
  const [inputDue, setInputDue] = useState(0);
  const [inputAdvance, setInputAdvance] = useState(0);
  const [selectedFabric, setSelectedFabric] = useState(null);
  const [price, setPrice] = useState(null);
  const [quantity, setQuantity] = useState(null);
  const [total, setTotal] = useState(null);
  const [discount, setDiscount] = useState(null);
  const [grandTotal, setGrandTotal] = useState(null);
  const [outfitType, setOutfitType] = useState(null);
  const [stitchingCost, setStitchingCost] = useState(null);
  const [discountB, setDiscountB] = useState(null);
  const [grandTotalB, setGrandTotalB] = useState(null);
  const [totalab, setTotalAB] = useState(null);
  const [rows, setRows] = useState([]);
  const [date, setDate] = useState("");
  const dateInputRef = useRef(null);
  const handleAddRowManually = () => {
    setRows([...rows, {}]);
  };
  const handleSubmit = (event) => {
    event.preventDefault();
    const newRow = {
      id: rows.length + 1,
      // id: id.id,
      fabricCode: selectedFabric.id,
      fabricDescription: selectedFabric.desc,
      price: price,
      quantity: quantity,
      total: total,
      discount: discount,
      grandTotalA: grandTotal,
      stitchingCost: stitchingCost,
      discountB: discountB,
      grandTotalB: grandTotalB,
      totalAB: totalab,
      outfitType: outfitType,
      date: selectedDate,
    };
    setRows([...rows, newRow]);
  };

  // const handleAddRow = () => {
  //   const newRow = {
  //     id: selectedVendor.fabrics.length + 1,
  //     fabric: null,
  //     price: 0,
  //     quantity: 0,
  //     discount: 0,
  //     stitchingCost: 0,
  //     discountB: 0,
  //     outfitType: "",
  //     date: new Date(),
  //   };
  //   setSelectedVendor({
  //     ...selectedVendor,
  //     fabrics: [...selectedVendor.fabrics, newRow],
  //   });
  // };
  // const newDue =  grandTotal - parseFloat(inputAdvance);
  // setDue(newDue.toFixed(2));
  // setInputDue(newDue.toFixed(2));
  const handleChange = (e) => {
    setDate(e.target.value);
  };

  const handleVendorChange = (event) => {
    setSelectedVendor(event.target.value);
    setSelectedFabric(null);
  };

  const handleFabricChange = (event) => {
    setSelectedFabric(event.target.value);
  };

  const handlePriceChange = (event) => {
    setPrice(event.target.value);
  };

  const handleQuantityChange = (event) => {
    setQuantity(event.target.value);
  };

  const handleOutfitTypeChange = (event) => {
    setOutfitType(event.target.value);
  };

  const handleStitchingCostChange = (event) => {
    setStitchingCost(event.target.value);
  };

  const handleDiscountBChange = (event) => {
    setDiscountB(event.target.value);
  };
  const hanleTotalABChange = (event) => {
    setTotalAB(event.target.value);
  };

  useEffect(() => {
    if (price !== null && quantity !== null) {
      setTotal(price * quantity);
    } else {
      setTotal(null);
    }
  }, [price, quantity]);

  useEffect(() => {
    if (total !== null && discount !== null) {
      setGrandTotal(total - discount);
    } else {
      setGrandTotal(null);
    }
  }, [total, discount]);

  useEffect(() => {
    if (stitchingCost !== null && discountB !== null) {
      setGrandTotalB(stitchingCost - discountB);
    } else {
      setGrandTotalB(null);
    }
  }, [stitchingCost, discountB]);

  useEffect(() => {
    if (grandTotal !== null && grandTotalB !== null) {
      setTotalAB(grandTotal + grandTotalB);
    } else {
      setTotalAB(null);
    }
  }, [grandTotal, grandTotalB]);

  // setGrandTotal(totalab.toFixed(2));

  // const newDue = totalab - parseFloat(inputAdvance);
  // setDue(newDue.toFixed(2));
  // setInputDue(newDue.toFixed(2));
  useEffect(() => {
    if (totalab !== null && inputDue !== null) {
      setAdvance(totalab - inputDue);
    } else {
      setAdvance(null);
    }
  }, [totalab, inputDue]);

  useEffect(() => {
    if (totalab !== null && inputAdvance !== null) {
      setInputDue(totalab - inputAdvance);
    } else {
      setInputDue(null);
    }
  }, [totalab, inputAdvance]);

  return (
    <div>
      <FormControl>
        <InputLabel id="vendor-select-label">Select Customer</InputLabel>
        <Select
          labelId="vendor-select-label"
          id="vendor-select"
          value={selectedVendor}
          onChange={handleVendorChange}
        >
          {mockDataTeam.map((vendor) => (
            <MenuItem key={vendor.id} value={vendor}>
              {vendor.vendorname}
            </MenuItem>
          ))}
        </Select>
      </FormControl>
      {selectedVendor && (
        <TableContainer component={Paper}>
          <Table>
            <TableHead>
              <TableRow>
                <TableCell>Fabric Code</TableCell>
                <TableCell>Fabric Description</TableCell>
                <TableCell>Price</TableCell>
                <TableCell>Quantity</TableCell>
                <TableCell>Total</TableCell>
                <TableCell>Discount</TableCell>
                <TableCell>Grand TotalA</TableCell>
                <TableCell>SwitchingCost</TableCell>
                <TableCell>DiscountB</TableCell>
                <TableCell>GrandTotalB</TableCell>
                <TableCell>Total A + B</TableCell>
                <TextField>OutfitType</TextField>
                <TableCell>
                  <input
                    type="date"
                    onChange={handleChange}
                    ref={dateInputRef}
                  />
                  <p>TrailDate: {date}</p>
                </TableCell>
                {/* <TableCell>
                <DatePicker
              selected={selectedDate}
              onChange={handleChange}
              dateFormat="dd/MM/yyyy"
            />
                </TableCell> */}
                <TableCell>
                  <Button
                    variant="contained"
                    color="primary"
                    onClick={handleAddRowManually}
                  >
                    Add Row Manually
                  </Button>
                </TableCell>
              </TableRow>
            </TableHead>
            <TableBody>
              {selectedVendor.fabrics.map((fabric) => (
                <TableRow key={fabric.id}>
                  <TableCell>
                    <FormControl>
                      <Select
                        labelId={`fabric-select-label-${fabric.id}`}
                        id={`fabric-select-${fabric.id}`}
                        value={selectedFabric === fabric ? fabric : ""}
                        onChange={handleFabricChange}
                      >
                        {selectedVendor.fabrics.map((option) => (
                          <MenuItem key={option.id} value={option}>
                            {option.id}
                          </MenuItem>
                        ))}
                      </Select>
                    </FormControl>
                  </TableCell>

                  <TableCell>
                    {selectedFabric === fabric && fabric.desc}
                  </TableCell>
                  <TableCell>
                    <input type="number" onChange={handlePriceChange} />
                  </TableCell>
                  <TableCell>
                    <input type="number" onChange={handleQuantityChange} />
                  </TableCell>
                  <TableCell>{total}</TableCell>
                  <TableCell>
                    <input
                      type="number"
                      onChange={(e) => setDiscount(e.target.value)}
                    />
                  </TableCell>
                  <TableCell>{grandTotal}</TableCell>
                  <TableCell>
                    <input type="number" onChange={handleStitchingCostChange} />
                  </TableCell>
                  <TableCell>
                    <input type="number" onChange={handleDiscountBChange} />
                  </TableCell>
                  <TableCell>{grandTotalB}</TableCell>
                  <TableCell>{totalab}</TableCell>
                  <TableCell>OutfitType</TableCell>
                </TableRow>
              ))}
            </TableBody>
          </Table>
          <span>Grand Total: {totalab}</span>
          <br />
          <TextField
            label="Advance"
            value={inputAdvance}
            onChange={(e) => setInputAdvance(e.target.value)}
          />
          <br />
          <TextField
            label="Due"
            value={inputDue}
            onChange={(e) => setInputDue(e.target.value)}
          />
          <input type="date" onChange={handleChange} ref={dateInputRef} />
          <p>Delivery Date: {date}</p>
          <Button
            variant="contained"
            onClick={() => {
              console.log("Saved");
            }}
          >
            Save
          </Button>
          <Button variant="contained" onClick={() => console.log("Cancelled")}>
            Cancel
          </Button>
        </TableContainer>
      )}
    </div>
  );
};

export default VendorTable;
