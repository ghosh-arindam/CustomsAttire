import { Check, Delete, Save } from "@mui/icons-material";
import { Box, CircularProgress, Fab } from "@mui/material";
import { green, blue } from "@mui/material/colors";
import React, { useState, useEffect } from "react";
import { useDispatch } from "react-redux";
import { deleteSupplier, updateSupplier } from "../../redux/action";
const SupplierAction = ({ params, rowId, setrowId }) => {
  const [loading, setLoading] = useState(false);
  const [success, setSuccess] = useState(false);
  const dispatch = useDispatch();
  const delay = (ms) => new Promise((resolve) => setTimeout(resolve, ms));

  const handleSubmit = async () => {
    setLoading(true);
    await delay(2000);
    const {
      rowId,
      accountNumber,
      vendorName,
      phoneNumber,
      address1,
      address2,
      city,
      panNo,
      gst,
      preferredVendorStatus,
      id,
    } = params.row;
    //console.log("handleSubmit:" + JSON.stringify(params.row));
    console.log("id:" + id);
    const supplierData = {
      rowId,
      accountNumber,
      vendorName,
      phoneNumber,
      address1,
      address2,
      city,
      panNo,
      gst,
      preferredVendorStatus,
    };

    const result = dispatch(updateSupplier(supplierData, id));
    if (result) {
      setSuccess(true);
      setrowId(null);
    }

    setLoading(false);
  };

  const handleDelete = async (e, id) => {
    if (window.confirm("Are you sure to delete the Customer?")) {
      e.stopPropagation();
      dispatch(deleteSupplier(id));
    }
  };

  useEffect(() => {
    //console.log("selectedrowId" + rowId);
    //console.log("params.id" + params.id);
    if (rowId === params.id && success) setSuccess(false);
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [rowId]);
  return (
    <Box
      sx={{
        m: 1,
        position: "relative",
      }}
    >
      {success ? (
        <Fab
          color="primary"
          sx={{
            width: 40,
            height: 40,
            bgcolor: green[500],
            "&:hover": { bgcolor: green[700] },
          }}
        >
          <Check />
        </Fab>
      ) : (
        <Fab
          color="primary"
          sx={{
            width: 40,
            height: 40,
          }}
          disabled={params.id !== rowId || loading}
          onClick={handleSubmit}
        >
          <Save />
        </Fab>
      )}
      {loading && (
        <CircularProgress
          size={52}
          sx={{
            color: green[500],
            position: "absolute",
            top: -6,
            left: -6,
            zIndex: 1,
          }}
        />
      )}

      <Fab
        color="secondary"
        sx={{
          mr: 1,
          width: 40,
          height: 40,
          bgcolor: blue[500],
          "&:hover": { bgcolor: green[700] },
        }}
        onClick={(e) => handleDelete(e, params.id)}
      >
        <Delete />
      </Fab>
    </Box>
  );
};

export default SupplierAction;
