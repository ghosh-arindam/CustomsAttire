import { useState, useEffect } from "react";
import { Box, TextField, MenuItem } from "@mui/material";
import { useDispatch, useSelector } from "react-redux";
import { loadProduct } from "../redux/action";

const ProductDropDownComponent = () => {
  const [fabricState, setFabricState] = useState();
  const { Products } = useSelector((state) => state.data);
  const dispatch = useDispatch();

  useEffect(() => {
    dispatch(loadProduct());
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, []);
  const handleSelectFabricChange = (event) => {
    console.log(event.target.value);
    setFabricState(event.target.value);
  };
  return (
    <Box>
      <TextField
        id="outlined-select"
        select
        label="Select Fabric"
        variant="outlined"
        style={{ width: 150 }}
        onChange={handleSelectFabricChange}
        InputLabelProps={{
          shrink: true,
        }}
        value={fabricState || ""}
        defaultValue={""}
        name="fabricCode"
        sx={{ gridColumn: "span 4" }}
      >
        {Products?.map((d, index) => (
          <MenuItem
            key={d.id}
            value={JSON.stringify({
              id: d.id,
              name: d.fabricCode,
              description: d.description,
            })}
          >
            {d.fabricCode}
          </MenuItem>
        ))}
        :<div></div>
      </TextField>
    </Box>
  );
};

export default ProductDropDownComponent;
